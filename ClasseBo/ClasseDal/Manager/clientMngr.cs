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

        public clientMngr()
        {
            this._clientRepository = new Repository<Client>();
        }

        #endregion

        #region Méthodes

        public IEnumerable<Client> getAllCli()
        {
            return _clientRepository.GetAll();
        }

        public Client GetClientById(int id)
        {
            return _clientRepository.GetSingleById(id);
        }


        public bool AjoutClient(Client cl)
        {
            try
            {
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
            _clientRepository.Delete(cl);
            _clientRepository.Save();
        }

        public void UpdatClient(Client cl)
        {
            _clientRepository.Update(cl);
            _clientRepository.Save();
        }


        #endregion
    }
}
