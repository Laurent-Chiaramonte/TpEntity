using ClasseBo.Exceptions;
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

        public IEnumerable<Client> getAllCli()
        {
            this._clientRepository = new Repository<Client>();
            return _clientRepository.GetAll();
        }

        public Client GetClientById(int id)
        {
            this._clientRepository = new Repository<Client>();
            return _clientRepository.GetSingleById(id);
        }


        public bool AjoutClient(Client cl)
        {
            try
            {
                this._clientRepository = new Repository<Client>();
                _clientRepository.Insert(cl);
                _clientRepository.Save();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public void SuppClient(Client cl)
        {
            this._clientRepository = new Repository<Client>();
            _clientRepository.Delete(cl);
            _clientRepository.Save();
        }

        public void UpdatClient(Client cl)
        {
            this._clientRepository = new Repository<Client>();
            _clientRepository.Update(cl);
            _clientRepository.Save();
        }


        #endregion
    }
}
