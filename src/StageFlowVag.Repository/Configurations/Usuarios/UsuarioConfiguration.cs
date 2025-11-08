using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StageFlowVag.Domain.Entities;
using StageFlowVag.Domain.Entities.Usuarios;

namespace StageFlowVag.Repository.Configurations.Usuarios
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(u => u.Nome).HasColumnName("nome").IsRequired().HasMaxLength(100);
            builder.Property(u => u.Matricula).HasColumnName("matricula").IsRequired().HasMaxLength(20);
            builder.Property(u => u.Email).HasColumnName("email").IsRequired().HasMaxLength(100);
            builder.Property(u => u.Role).HasColumnName("role").IsRequired();
            builder.Property(u => u.Telefone).HasColumnName("telefone").HasMaxLength(20);
            builder.Property(u => u.Departamento).HasColumnName("departamento").HasMaxLength(50);

            builder.Property(u => u.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(u => u.CriadoEm).HasColumnName("criado_em").IsRequired();
            builder.Property(u => u.AlteradoEm).HasColumnName("alterado_em");
            builder.Property(u => u.DeletadoEm).HasColumnName("deletado_em");

            builder.HasMany(u => u.Solicitacoes)
                .WithOne(s => s.Solicitante)
                .HasForeignKey(s => s.SolicitanteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(u => u.Atendimentos)
                .WithOne(a => a.Responsavel)
                .HasForeignKey(a => a.ResponsavelId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasIndex(u => u.Matricula).HasDatabaseName("idx_usuarios_matricula").IsUnique();
            builder.HasIndex(u => u.Email).HasDatabaseName("idx_usuarios_email").IsUnique();
            builder.HasIndex(u => u.Role).HasDatabaseName("idx_usuarios_role");

            builder.HasQueryFilter(u => u.IsActive);
        }
    }
}