using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseDal.Configuration
{
    class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientConfiguration() : base()
        {
            #region Mapping Proprietes

            HasKey(p => p.num_client);
            Property(p => p.nom_client)
                .HasColumnName("NomClient")
                .IsRequired()
                .HasMaxLength(30);
            Property(p => p.adresse_client)
                .HasColumnName("AdresseClient")
                .IsRequired()
                .HasMaxLength(30);
            Property(p => p.cp_client)
                .HasColumnName("CpClient")
                .IsRequired()
                .HasMaxLength(5);
            Property(p => p.ville_client)
                .HasColumnName("VilleClient")
                .IsRequired()
                .HasMaxLength(30);
            Property(p => p.tel_client)
                .HasColumnName("TelClient")
                .IsOptional()
                .HasMaxLength(10);


            #endregion

            #region Associations

            //Centres

            HasMany(p => p.Centres)
                .WithRequired()
                .HasForeignKey(p => p.NumCli);



            #endregion



        }
    }
}
