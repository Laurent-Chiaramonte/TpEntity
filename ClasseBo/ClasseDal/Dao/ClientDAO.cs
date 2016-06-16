using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasseBo.Exceptions;
using ClasseDal.Exceptions;

namespace ClasseDal.Dao
{
    internal class clientDAO : IRepository<Client>
    {
        public clientDAO() { }

        public void Delete(Client obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetAll()
        {
            throw new NotImplementedException();
        }

        public Client GetSingleById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Client obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Client obj)
        {
            throw new NotImplementedException();
        }
    }
}
