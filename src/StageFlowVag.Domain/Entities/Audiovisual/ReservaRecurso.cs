using StageFlowVag.Domain.Base;
using StageFlowVag.Domain.Enums.AudioVisualEnum;

namespace StageFlowVag.Domain.Entities.Audiovisual
{
    public class ReservaRecurso : BaseEntity
    {
        public int EventoId { get; set; }
        public Evento Evento { get; set; } = null!;
        
        public int RecursoId { get; set; }
        public RecursoAudioVisual Recurso { get; set; } = null!;
        public int Quantidade { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set;  }
        public StatusReserva Status { get; set;  }
        public string? ObservacoesReserva { get; set; }
        public DateTime? DataHoraEntrega { get; set; }
        public DateTime? DataHoraDevolucao { get; set; }
        public string? ResponsavelEntrega { get; set; }
        public string? ResponsavelDevolucao { get; set; }

    }
}
