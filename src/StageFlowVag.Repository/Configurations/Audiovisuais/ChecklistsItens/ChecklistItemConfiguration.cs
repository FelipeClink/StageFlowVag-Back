using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StageFlowVag.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Repository.Configurations.Audiovisuais.ChecklistsItens
{
    public class ChecklistItemConfiguration : IEntityTypeConfiguration<ChecklistItem>
    {
        public void Configure(EntityTypeBuilder<ChecklistItem> builder)
        {
            builder.ToTable("checklist_item");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            builder.Property(c => c.EventoId)
                .HasColumnName("evento_id")
                .IsRequired();

            builder.Property(c => c.Titulo)
                .HasColumnName("titulo")
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.Descricao)
                .HasColumnName("descricao")
                .HasMaxLength(1000);

            builder.Property(c => c.SetorResponsavel)
                .HasColumnName("setor_responsavel")
                .IsRequired();

            builder.Property(c => c.Prioridade)
                .HasColumnName("prioridade")
                .IsRequired();

            builder.Property(c => c.Status)
                .HasColumnName("status")
                .IsRequired();

            builder.Property(c => c.DataLimite)
                .HasColumnName("data_limite");

            builder.Property(c => c.DataConclusao)
                .HasColumnName("data_conclusao");

            builder.Property(c => c.ResponsavelNome)
                .HasColumnName("responsavel_nome")
                .HasMaxLength(100);

            builder.Property(c => c.ObservacoesConclusao)
                .HasColumnName("observacoes_conclusao")
                .HasMaxLength(1000);

            builder.Property(c => c.GeradoAutomaticamente)
                .HasColumnName("gerado_automaticamente")
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(c => c.IsActive)
                .HasColumnName("is_active")
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(c => c.CriadoEm)
                .HasColumnName("criado_em")
                .IsRequired();

            builder.Property(c => c.AlteradoEm)
                .HasColumnName("alterado_em");

            builder.Property(c => c.DeletadoEm)
                .HasColumnName("deletado_em");

            builder.HasOne(c => c.Evento)
                .WithMany(e => e.Checklist)
                .HasForeignKey(c => c.EventoId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(c => c.EventoId)
                .HasDatabaseName("idx_checklist_evento");

            builder.HasIndex(c => c.Status)
                .HasDatabaseName("idx_checklist_status");

            builder.HasIndex(c => c.SetorResponsavel)
                .HasDatabaseName("idx_checklist_setor");

            builder.HasIndex(c => c.DataLimite)
                .HasDatabaseName("idx_checklist_data_limite");

            builder.HasQueryFilter(c => c.IsActive);
        }
    }
}