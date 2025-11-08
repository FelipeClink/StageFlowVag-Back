using Microsoft.EntityFrameworkCore;
using StageFlowVag.Domain.Entities;
using StageFlowVag.Domain.Entities.AtendimentosDepartamentos;
using StageFlowVag.Domain.Entities.Blocos;
using StageFlowVag.Domain.Entities.Insumos;
using StageFlowVag.Domain.Entities.Solicitacoes;
using StageFlowVag.Domain.Entities.Solicitacoes.SolicitacoesInsumos;
using StageFlowVag.Domain.Entities.Usuarios;

namespace StageFlowVag.Repository
{
    public class StageFlowVagDbContext : DbContext
    {
        public StageFlowVagDbContext(DbContextOptions<StageFlowVagDbContext> options)
            : base(options)
        {
        }

        // DbSets
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Solicitacao> Solicitacoes { get; set; }
        public DbSet<Insumo> Insumos { get; set; }
        public DbSet<SolicitacaoInsumo> SolicitacaoInsumos { get; set; }
        public DbSet<Bloco> Blocos { get; set; }
        public DbSet<DisponibilidadeBloco> DisponibilidadeBlocos { get; set; }
        public DbSet<AtendimentoDepartamento> AtendimentoDepartamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aplicar todas as configurações do assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StageFlowVagDbContext).Assembly);
        }
    }
}