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

        private IRepository<Client> _clientRepository;

        #region Constructeurs

        public clientMngr() { }

        #endregion

        #region Méthodes

        internal IEnumerable<Client> getAllCli()
        {
            //clientDAO cliDAO = new clientDAO();
            //IEnumerable<Client> cli = cliDAO.GetAll();
            //return cli;
            this._clientRepository = new Repository<Client>();
            return _clientRepository.GetAll();
        }

        //public Client monCli(int id)
        //{
        //    try
        //    {
        //        Lclient = moncliPro.GetClientByID(id);

        //        if (Lclient == null)
        //        {
        //            throw new ClientException("Le client n'existe pas");
        //        }
        //        else
        //        {
        //            return Lclient;
        //        }
        //    }
        //    catch (ClientException mess)
        //    {
        //        throw new ClientException("Client non trouvé", mess);
        //    }
        //}

        //public Client createCli(string nomcli, string adressecli, string cpcli, string villecli, string telcli)
        //{
        //    Client cli = new Client();
        //    cli.nom_client = nomcli;
        //    cli.adresse_client = adressecli;
        //    cli.cp_client = cpcli;
        //    cli.ville_client = villecli;
        //    cli.tel_client = telcli;

        //    return cli;
        //}

        #endregion
    }
}
