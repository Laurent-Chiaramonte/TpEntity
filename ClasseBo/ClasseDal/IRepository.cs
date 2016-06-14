﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseDal
{
    public interface IRepository<T>
    {
        void Insert(T obj);
        void Delete(T obj);
        void Update(T obj);
        ICollection<T> GetAll();
        T GetById(object id);
    }
}