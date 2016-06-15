using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ClasseDal.Configuration;

namespace ClasseDal
{
    public class TpContext : DbContext 
    {
        public TpContext() : base("name=TpEntity") { }

        #region DBSET
        public DbSet<CentreInformatique> CentresInformatique { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contrat> Contrats { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new ClientConfiguration());
            modelBuilder.Configurations.Add(new CentreInformatiqueConfiguration());
            modelBuilder.Configurations.Add(new ContratConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
