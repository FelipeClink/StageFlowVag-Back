using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StageFlowVag.Domain.Entities.Audiovisual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Repository.Configurations.Audiovisuais.ReservasRecursos
{
    public class ReservaRecursoConfiguration : IEntityTypeConfiguration<ReservaRecurso>
    {
        public void Configure(EntityTypeBuilder<ReservaRecurso> builder)
        {
            builder.ToTable("reserva_recurso");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            builder.Property(r => r.EventoId)
                .HasColumnName("evento_id")
                .IsRequired();

            builder.Property(r => r.RecursoId)
                .HasColumnName("recurso_id")
                .IsRequired();

            builder.Property(r => r.Quantidade)
                .HasColumnName("quantidade")
                .IsRequired();

            builder.Property(r => r.DataHoraInicio)
                .HasColumnName("data_hora_inicio")
                .IsRequired();

            builder.Property(r => r.DataHoraFim)
                .HasColumnName("data_hora_fim")
                .IsRequired();

            builder.Property(r => r.Status)
                .HasColumnName("status")
                .IsRequired();

            builder.Property(r => r.ObservacoesReserva)
                .HasColumnName("observacoes_reserva")
                .HasMaxLength(1000);

            builder.Property(r => r.DataHoraEntrega)
                .HasColumnName("data_hora_entrega");

            builder.Property(r => r.DataHoraDevolucao)
                .HasColumnName("data_hora_devolucao");

            builder.Property(r => r.ResponsavelEntrega)
                .HasColumnName("responsavel_entrega")
                .HasMaxLength(100);

            builder.Property(r => r.ResponsavelDevolucao)
                .HasColumnName("responsavel_devolucao")
                .HasMaxLength(100);

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

            builder.HasOne(r => r.Evento)
                .WithMany(e => e.RecursosReservados)
                .HasForeignKey(r => r.EventoId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(r => r.Recurso)
                .WithMany(rec => rec.Reservas)
                .HasForeignKey(r => r.RecursoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(r => r.EventoId)
                .HasDatabaseName("idx_reservas_evento");

            builder.HasIndex(r => r.RecursoId)
                .HasDatabaseName("idx_reservas_recurso");

            builder.HasIndex(r => r.Status)
                .HasDatabaseName("idx_reservas_status");

            builder.HasIndex(r => new { r.DataHoraInicio, r.DataHoraFim })
                .HasDatabaseName("idx_reservas_periodo");

            // Filtro global para IsActive
            builder.HasQueryFilter(r => r.IsActive);
        }
    }
}
