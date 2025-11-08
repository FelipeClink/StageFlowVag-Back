using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StageFlowVag.Domain.Entities.Audiovisual;

namespace StageFlowVag.Repository.Configurations
{
    public class EventoConfiguration : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.ToTable("eventos");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Titulo)
                .HasColumnName("titulo")
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.Descricao)
                .HasColumnName("descricao")
                .HasMaxLength(1000);

            builder.Property(e => e.DataInicio)
                .HasColumnName("data_inicio")
                .IsRequired();

            builder.Property(e => e.DataFim)
                .HasColumnName("data_fim")
                .IsRequired();

            builder.Property(e => e.Local)
                .HasColumnName("local")
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.PublicoEstimado)
                .HasColumnName("publico_estimado")
                .IsRequired();

            builder.Property(e => e.Status)
                .HasColumnName("status")
                .IsRequired();

            builder.Property(e => e.CoordenadorId)
                .HasColumnName("coordenador_id")
                .IsRequired();

            builder.Property(e => e.NomeCoordenador)
                .HasColumnName("nome_coordenador")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.EmailCoordenador)
                .HasColumnName("email_coordenador")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.CursoVinculado)
                .HasColumnName("curso_vinculado")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.TipoEvento)
                .HasColumnName("tipo_evento")
                .IsRequired();

            builder.Property(e => e.RequerDivulgacao)
                .HasColumnName("requer_divulgacao")
                .IsRequired();

            builder.Property(e => e.RequerCerimonial)
                .HasColumnName("requer_cerimonial")
                .IsRequired();

            builder.Property(e => e.ObservacoesGerais)
                .HasColumnName("observacoes_gerais")
                .HasMaxLength(2000);

            // Propriedades da BaseEntity
            builder.Property(e => e.IsActive)
                .HasColumnName("is_active")
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(e => e.CriadoEm)
                .HasColumnName("criado_em")
                .IsRequired();

            builder.Property(e => e.AlteradoEm)
                .HasColumnName("alterado_em");

            builder.Property(e => e.DeletadoEm)
                .HasColumnName("deletado_em");

            // Relacionamentos
            builder.HasMany(e => e.RecursosReservados)
                .WithOne(r => r.Evento)
                .HasForeignKey(r => r.EventoId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(e => e.Checklist)
                .WithOne(c => c.Evento)
                .HasForeignKey(c => c.EventoId)
                .OnDelete(DeleteBehavior.Cascade);

            // Índices
            builder.HasIndex(e => e.DataInicio)
                .HasDatabaseName("idx_eventos_data_inicio");

            builder.HasIndex(e => e.Status)
                .HasDatabaseName("idx_eventos_status");

            builder.HasIndex(e => e.CoordenadorId)
                .HasDatabaseName("idx_eventos_coordenador");

            builder.HasIndex(e => e.Local)
                .HasDatabaseName("idx_eventos_local");

            // Filtro global para IsActive
            builder.HasQueryFilter(e => e.IsActive);
        }
    }
}