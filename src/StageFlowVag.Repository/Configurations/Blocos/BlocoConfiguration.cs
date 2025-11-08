using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StageFlowVag.Domain.Entities;
using StageFlowVag.Domain.Entities.Blocos;

namespace StageFlowVag.Repository.Configurations.Blocos
{
    public class BlocoConfiguration : IEntityTypeConfiguration<Bloco>
    {
        public void Configure(EntityTypeBuilder<Bloco> builder)
        {
            builder.ToTable("blocos");
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(b => b.Nome).HasColumnName("nome").IsRequired().HasMaxLength(100);
            builder.Property(b => b.Descricao).HasColumnName("descricao").HasMaxLength(500);
            builder.Property(b => b.Capacidade).HasColumnName("capacidade").IsRequired();
            builder.Property(b => b.Localizacao).HasColumnName("localizacao").HasMaxLength(200);
            builder.Property(b => b.Observacoes).HasColumnName("observacoes").HasMaxLength(1000);

            // BaseEntity
            builder.Property(b => b.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(b => b.CriadoEm).HasColumnName("criado_em").IsRequired();
            builder.Property(b => b.AlteradoEm).HasColumnName("alterado_em");
            builder.Property(b => b.DeletadoEm).HasColumnName("deletado_em");

            // Relacionamentos
            builder.HasMany(b => b.Disponibilidades)
                .WithOne(d => d.Bloco)
                .HasForeignKey(d => d.BlocoId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(b => b.Solicitacoes)
                .WithOne(s => s.Bloco)
                .HasForeignKey(s => s.BlocoId)
                .OnDelete(DeleteBehavior.SetNull);

            // Índices
            builder.HasIndex(b => b.Nome).HasDatabaseName("idx_blocos_nome");

            builder.HasQueryFilter(b => b.IsActive);
        }
    }
}