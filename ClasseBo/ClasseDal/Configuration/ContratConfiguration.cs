using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ClasseDal.Configuration
{
    class ContratConfiguration : EntityTypeConfiguration<Contrat>
    {
        public ContratConfiguration() : base()
        {
            #region Mapping Proprietes

            HasKey(p => p.num_contrat);
            Property(p => p.montant_contrat)
                .HasColumnName("MontantContrat")
                .IsRequired();
            Property(p => p.date_validite_contrat)
                .HasColumnName("DateValidContrat")
                .IsRequired()
                .HasColumnType("Date");
            Property(p => p.date_echeance_contrat)
                .HasColumnName("DateEchContrat")
                .IsRequired()
                .HasColumnType("Date");
            Property(p => p.date_resiliation_contrat)
                .HasColumnName("DateResContrat")
                .IsOptional()
                .HasColumnType("Date");
            Property(p => p.commentaire_contrat)
                .HasColumnName("CommContrat")
                .IsOptional()
                .HasMaxLength(30);
            Property(p => p.statut)
                .HasColumnName("Statut")
                .IsRequired();

            #endregion

            #region Associations

            //HasRequired(p => p.Client)
            //    .WithMany()
            //    .HasForeignKey(p => p.IdClient);

            HasRequired(p => p.Centre)
                .WithMany()
                .HasForeignKey(p => p.IdCentre);

            #endregion
        }
    }
}
