using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ClasseDal.Configuration
{
    class CentreInformatiqueConfiguration : EntityTypeConfiguration<CentreInformatique>
    {
        public CentreInformatiqueConfiguration() : base()
        {
            #region Mapping Proprietes

            HasKey(p => p.num_centre);

            Property(p => p.adresse_centre)
                .HasColumnName("AdresseCentre")
                .IsRequired()
                .HasMaxLength(30);
            Property(p => p.cpl_centre)
                .HasColumnName("CpCentre")
                .IsRequired()
                .HasMaxLength(5);
            Property(p => p.ville_centre)
                .HasColumnName("VilleCentre")
                .IsRequired()
                .HasMaxLength(30);
            Property(p => p.tel_centre)
                .HasColumnName("TelCentre")
                .IsRequired()
                .HasMaxLength(10);

            #endregion

            #region Associations

            //Client
          

            //Contrat



            #endregion 
        }
    }
}
