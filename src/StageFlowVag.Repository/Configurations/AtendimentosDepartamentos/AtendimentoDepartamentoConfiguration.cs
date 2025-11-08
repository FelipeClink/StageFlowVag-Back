using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StageFlowVag.Domain.Entities;
using StageFlowVag.Domain.Entities.AtendimentosDepartamentos;

namespace StageFlowVag.Repository.Configurations.AtendimentosDepartamentos
{
    public class AtendimentoDepartamentoConfiguration : IEntityTypeConfiguration<AtendimentoDepartamento>
    {
        public void Configure(EntityTypeBuilder<AtendimentoDepartamento> builder)
        {
            builder.ToTable("atendimento_departamento");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(a => a.SolicitacaoId).HasColumnName("solicitacao_id").IsRequired();
            builder.Property(a => a.Departamento).HasColumnName("departamento").IsRequired();
            builder.Property(a => a.Status).HasColumnName("status").IsRequired();
            builder.Property(a => a.ResponsavelId).HasColumnName("responsavel_id");
            builder.Property(a => a.DataInicio).HasColumnName("data_inicio");
            builder.Property(a => a.DataConclusao).HasColumnName("data_conclusao");
            builder.Property(a => a.Observacoes).HasColumnName("observacoes").HasMaxLength(1000);

            // BaseEntity
            builder.Property(a => a.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(a => a.CriadoEm).HasColumnName("criado_em").IsRequired();
            builder.Property(a => a.AlteradoEm).HasColumnName("alterado_em");
            builder.Property(a => a.DeletadoEm).HasColumnName("deletado_em");

            // Relacionamentos
            builder.HasOne(a => a.Solicitacao)
                .WithMany(s => s.Atendimentos)
                .HasForeignKey(a => a.SolicitacaoId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(a => a.Responsavel)
                .WithMany(u => u.Atendimentos)
                .HasForeignKey(a => a.ResponsavelId)
                .OnDelete(DeleteBehavior.SetNull);

            // Índices
            builder.HasIndex(a => a.SolicitacaoId).HasDatabaseName("idx_atendimento_solicitacao");
            builder.HasIndex(a => a.Departamento).HasDatabaseName("idx_atendimento_departamento");
            builder.HasIndex(a => a.Status).HasDatabaseName("idx_atendimento_status");

            builder.HasQueryFilter(a => a.IsActive);
        }
    }
}