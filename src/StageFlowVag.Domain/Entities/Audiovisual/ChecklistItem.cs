using StageFlowVag.Domain.Base;
using StageFlowVag.Domain.Entities.Audiovisual;
using StageFlowVag.Domain.Enums;
using StageFlowVag.Domain.Enums.AudioVisualEnum;

namespace StageFlowVag.Domain.Entities
{
    public class ChecklistItem : BaseEntity
    {
        public int EventoId { get; set; }
        public Evento Evento { get; set; } = null!;

        public string Titulo { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public SetorResponsavel SetorResponsavel { get; set; }
        public PrioridadeTarefa Prioridade { get; set; }
        public StatusTarefa Status { get; set; }

        public DateTime? DataLimite { get; set; }
        public DateTime? DataConclusao { get; set; }

        public string? ResponsavelNome { get; set; }
        public string? ObservacoesConclusao { get; set; }

        // Flag para indicar se foi gerado automaticamente
        public bool GeradoAutomaticamente { get; set; }
    }
}