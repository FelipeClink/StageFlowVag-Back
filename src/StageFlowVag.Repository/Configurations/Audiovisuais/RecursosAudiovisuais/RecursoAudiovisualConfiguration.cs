using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StageFlowVag.Domain.Entities.Audiovisual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Repository.Configurations.Audiovisuais.RecursosAudiovisuais
{
    public class RecursoAudiovisualConfiguration : IEntityTypeConfiguration<RecursoAudioVisual>
    {
        public void Configure(EntityTypeBuilder<RecursoAudioVisual> builder)
        {
            builder.ToTable("recurso_audiovisual");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            builder.Property(r => r.Nome)
                .HasColumnName("nome")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(r => r.Descricao)
                .HasColumnName("descricao")
                .HasMaxLength(500);

            builder.Property(r => r.Tipo)
                .HasColumnName("tipo")
                .IsRequired();

            builder.Property(r => r.Status)
                .HasColumnName("status")
                .IsRequired();

            builder.Property(r => r.QuantidadeDisponivel)
                .HasColumnName("quantidade_disponivel")
                .IsRequired();

            builder.Property(r => r.NumeroPatrimonio)
                .HasColumnName("numero_patrimonio")
                .HasMaxLength(50);

            builder.Property(r => r.Observacoes)
                .HasColumnName("observacoes")
                .HasMaxLength(1000);

            builder.Property(r => r.IsActive)
                .HasColumnName("is_active")
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(r => r.CriadoEm)
                .HasColumnName("criado_em")
                .IsRequired();

            builder.Property(r => r.AlteradoEm)
                .HasColumnName("alterado_em");

            builder.Property(r => r.DeletadoEm)
                .HasColumnName("deletado_em");

           
            builder.HasMany(r => r.Reservas)
                .WithOne(res => res.Recurso)
                .HasForeignKey(res => res.RecursoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(r => r.Tipo)
                .HasDatabaseName("idx_recursos_tipo");

            builder.HasIndex(r => r.Status)
                .HasDatabaseName("idx_recursos_status");

            builder.HasIndex(r => r.NumeroPatrimonio)
                .HasDatabaseName("idx_recursos_patrimonio");

            builder.HasQueryFilter(r => r.IsActive);
        }
    }
}