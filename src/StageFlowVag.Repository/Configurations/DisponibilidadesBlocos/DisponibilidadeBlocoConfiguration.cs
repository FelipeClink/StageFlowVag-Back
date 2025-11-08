using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StageFlowVag.Domain.Entities.Blocos;

namespace StageFlowVag.Repository.Configurations.DisponibilidadesBlocos
{
    public class DisponibilidadeBlocoConfiguration : IEntityTypeConfiguration<DisponibilidadeBloco>
    {
        public void Configure(EntityTypeBuilder<DisponibilidadeBloco> builder)
        {
            builder.ToTable("disponibilidade_blocos");
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(d => d.BlocoId).HasColumnName("bloco_id").IsRequired();
            builder.Property(d => d.DataHoraInicio).HasColumnName("data_hora_inicio").IsRequired();
            builder.Property(d => d.DataHoraFim).HasColumnName("data_hora_fim").IsRequired();
            builder.Property(d => d.Status).HasColumnName("status").IsRequired();
            builder.Property(d => d.SolicitacaoId).HasColumnName("solicitacao_id");
            builder.Property(d => d.Observacoes).HasColumnName("observacoes").HasMaxLength(500);

            // BaseEntity
            builder.Property(d => d.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(d => d.CriadoEm).HasColumnName("criado_em").IsRequired();
            builder.Property(d => d.AlteradoEm).HasColumnName("alterado_em");
            builder.Property(d => d.DeletadoEm).HasColumnName("deletado_em");

            // Relacionamentos
            builder.HasOne(d => d.Bloco)
                .WithMany(b => b.Disponibilidades)
                .HasForeignKey(d => d.BlocoId)
                .OnDelete(DeleteBehavior.Cascade);

            // Índices
            builder.HasIndex(d => d.BlocoId).HasDatabaseName("idx_disponibilidade_bloco");
            builder.HasIndex(d => d.Status).HasDatabaseName("idx_disponibilidade_status");
            builder.HasIndex(d => new { d.DataHoraInicio, d.DataHoraFim }).HasDatabaseName("idx_disponibilidade_periodo");

            builder.HasQueryFilter(d => d.IsActive);
        }
    }
}