using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StageFlowVag.Domain.Entities.Solicitacoes;

namespace StageFlowVag.Repository.Configurations.Solicitatoes
{
    public class SolicitacaoConfiguration : IEntityTypeConfiguration<Solicitacao>
    {
        public void Configure(EntityTypeBuilder<Solicitacao> builder)
        {
            builder.ToTable("solicitacoes");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(s => s.NomeEvento).HasColumnName("nome_evento").IsRequired().HasMaxLength(200);
            builder.Property(s => s.Descricao).HasColumnName("descricao").HasMaxLength(1000);
            builder.Property(s => s.DataEvento).HasColumnName("data_evento").IsRequired();
            builder.Property(s => s.Local).HasColumnName("local").IsRequired().HasMaxLength(200);
            builder.Property(s => s.PublicoEstimado).HasColumnName("publico_estimado").IsRequired();

            builder.Property(s => s.Aprovado).HasColumnName("aprovado");
            builder.Property(s => s.DataAprovacao).HasColumnName("data_aprovacao");
            builder.Property(s => s.AprovadoPorId).HasColumnName("aprovado_por_id");
            builder.Property(s => s.JustificativaRejeicao).HasColumnName("justificativa_rejeicao").HasMaxLength(500);

            builder.Property(s => s.SolicitanteId).HasColumnName("solicitante_id").IsRequired();
            builder.Property(s => s.BlocoId).HasColumnName("bloco_id");

            // BaseEntity
            builder.Property(s => s.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(s => s.CriadoEm).HasColumnName("criado_em").IsRequired();
            builder.Property(s => s.AlteradoEm).HasColumnName("alterado_em");
            builder.Property(s => s.DeletadoEm).HasColumnName("deletado_em");

            // Relacionamentos
            builder.HasOne(s => s.Solicitante)
                .WithMany(u => u.Solicitacoes)
                .HasForeignKey(s => s.SolicitanteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.Bloco)
                .WithMany(b => b.Solicitacoes)
                .HasForeignKey(s => s.BlocoId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(s => s.Insumos)
                .WithOne(si => si.Solicitacao)
                .HasForeignKey(si => si.SolicitacaoId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(s => s.Atendimentos)
                .WithOne(a => a.Solicitacao)
                .HasForeignKey(a => a.SolicitacaoId)
                .OnDelete(DeleteBehavior.Cascade);

            // Índices
            builder.HasIndex(s => s.DataEvento).HasDatabaseName("idx_solicitacoes_data");
            builder.HasIndex(s => s.SolicitanteId).HasDatabaseName("idx_solicitacoes_solicitante");
            builder.HasIndex(s => s.Aprovado).HasDatabaseName("idx_solicitacoes_aprovado");
            builder.HasIndex(s => s.BlocoId).HasDatabaseName("idx_solicitacoes_bloco");

            builder.HasQueryFilter(s => s.IsActive);
        }
    }
}