using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasseBo.Exceptions;
using ClasseDal.Exceptions;

namespace ClasseDal.Dao
{
    //internal class clientDAO : IRepository<Client>
    //{
    //    public clientDAO() { }

    //    public object Insert(Client cl)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(Client id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update(Client cl)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public ICollection<Client> GetAll()
    //    {
    //        using (TpContext tpx = new TpContext())
    //        {
    //            try
    //            {
    //                var query = tpx.Clients.ToList();
    //                return query;
    //            }
    //            catch (Exception ex)
    //            {
    //                throw new DaoExceptionAfficheMessage(ex.Message);
    //            }                
    //        }
    //    }

    //    internal Client GetSingleByID(int idcli)
    //    {
    //        using (TpContext tpx = new TpContext())
    //        {
    //            try
    //            {
    //                var cli = tpx.Clients.Find(idcli);
    //                return cli;
    //            }
    //            catch (ClientException ex)
    //            {
    //                throw new ClientException(ex.Message);
    //            }
    //        }
    //    }

    //}
}
