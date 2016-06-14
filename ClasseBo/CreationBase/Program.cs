using ClasseDal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new TpInitializer());
            using (var context = new TpContext())
            {
                context.Database.Initialize(false);
            }
        }
    }
}
