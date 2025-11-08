using Microsoft.EntityFrameworkCore;
using StageFlowVag.Domain.Entities;
using StageFlowVag.Domain.Entities.Audiovisual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Repository
{
    public class StageFlowVagDbContext : DbContext
    {
        public StageFlowVagDbContext(DbContextOptions<StageFlowVagDbContext> options)
           : base(options)
        {
        }

        // DbSets
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<RecursoAudioVisual> RecursosAudiovisuais { get; set; }
        public DbSet<ReservaRecurso> ReservasRecursos { get; set; }
        public DbSet<ChecklistItem> ChecklistItens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aplicar todas as configurações do assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StageFlowVagDbContext).Assembly);
        }
    }
}
