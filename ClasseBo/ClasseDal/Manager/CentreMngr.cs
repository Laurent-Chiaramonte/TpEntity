using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseDal.Manager
{
    public class centreMngr
    {
        private IRepository<CentreInformatique> _centreRepository;

        #region Constructeurs
        public centreMngr()
        {
            this._centreRepository = new Repository<CentreInformatique>();
        }

        #endregion

        #region Méthodes

        public IEnumerable<CentreInformatique> getAllCent()
        {
            return _centreRepository.GetAll();
        }

        public CentreInformatique GetCentreById(int id)
        {
            return _centreRepository.GetSingleById(id);
        }

        public bool AjoutCentre(CentreInformatique ci)
        {
            try
            {
                _centreRepository.Insert(ci);
                _centreRepository.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void SuppCentre(CentreInformatique ci)
        {
            _centreRepository.Delete(ci);
            _centreRepository.Save();
        }

        public void UpdatCentre(CentreInformatique ci)
        {
            _centreRepository.Update(ci);
            _centreRepository.Save();
        }

        public IEnumerable<CentreInformatique> getCentresByClient(int id)
        {
            IEnumerable<CentreInformatique> cebyid = _centreRepository.GetAll();
            var lst = cebyid.Where(p => p.NumCli == id).ToList();
            return lst;
        }

        #endregion

    }
}
