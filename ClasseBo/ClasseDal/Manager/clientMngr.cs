using ClasseBo.Exceptions;
using ClasseDal.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseDal.Manager
{
    public class clientMngr
    {

        private clientDAO moncliPro = new clientDAO();
        private Client Lclient;

        #region Constructeurs

        public clientMngr() { }

        #endregion

        #region Méthodes

        public ICollection<Client> getAllCli()
        {
            return moncliPro.GetAllClient();
        }

        public Client monCli(int id)
        {
            try
            {
                Lclient = moncliPro.GetClientByID(id);

                if (Lclient == null)
                {
                    throw new ClientException("Le client n'existe pas");
                }
                else
                {
                    return Lclient;
                }
            }
            catch (ClientException mess)
            {
                throw new ClientException("Client non trouvé", mess);
            }
        }

        public Client createCli(string nomcli, string adressecli, string cpcli, string villecli, string telcli)
        {
            Client cli = new Client();
            cli.nom_client = nomcli;
            cli.adresse_client = adressecli;
            cli.cp_client = cpcli;
            cli.ville_client = villecli;
            cli.tel_client = telcli;

            return cli;
        }

        #endregion
    }
}
