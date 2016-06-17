using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace ClasseDal
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private TpContext context;
        private DbSet<T> dbSet;

        public Repository()
        {
            this.context = new TpContext();
            dbSet = context.Set<T>();
        }

        public ICollection<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetSingleById(int Id)
        {
            return dbSet.Find(Id);
        }

        public void Insert(T obj)
        {
            dbSet.Add(obj);
        }

        public void Update(T obj)
        {
            context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(T obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
