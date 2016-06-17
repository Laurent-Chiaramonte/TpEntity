using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseDal
{
    public interface IRepository<TEntity> where TEntity : class
    {
        ICollection<TEntity> GetAll();
        TEntity GetSingleById(int Id);
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        void Save();
    }
}
