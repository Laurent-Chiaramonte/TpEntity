using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasseBo.Exceptions;

namespace ClasseDal.Dao
{
    internal class clientDAO
    {
        public clientDAO() { }

        internal ICollection<Client> GetAllClient()
        {
            using (TpContext tpx = new TpContext())
            {
                return tpx.Clients.ToArray();
            }
        }

        internal Client GetClientByID(int idcli)
        {
            using (TpContext tpx = new TpContext())
            {
                try
                {
                    var cli = tpx.Clients.Find(idcli);
                    return cli;
                }
                catch (ClientException ex)
                {
                    throw new ClientException(ex.Message);
                }
            }
        }

    }
}
