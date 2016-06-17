using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseDal.Manager
{
    public class contratMngr
    {
        private IRepository<Contrat> _contratRepository;

        #region Constructeurs

        public contratMngr()
        {
            this._contratRepository = new Repository<Contrat>();
        }

        #endregion

        #region Méthodes

        public ICollection<Contrat> getAllCon()
        {
            return _contratRepository.GetAll();
        }

        public Contrat GetContratById(int id)
        {
            return _contratRepository.GetSingleById(id);
        }


        public bool AjoutContrat(Contrat ct)
        {
            try
            {
                _contratRepository.Insert(ct);
                _contratRepository.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void SuppContrat(Contrat ct)
        {
            _contratRepository.Delete(ct);
            _contratRepository.Save();
        }

        public void UpdatContrat(Contrat ct)
        {
            _contratRepository.Update(ct);
            _contratRepository.Save();
        }


        #endregion
    }
}
