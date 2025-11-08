using StageFlowVag.Communication.Enums.AudioVisualEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Communication.Responses.ReservasRecursos
{
    public class ReservaRecursoResponse
    {
        public Guid Id { get; set; }
        public Guid EventoId { get; set; }
        public string? TituloEvento { get; set; }
        public Guid RecursoId { get; set; }
        public string NomeRecurso { get; set; } = string.Empty;
        public TipoRecursoAudiovisual TipoRecurso { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public StatusReserva Status { get; set; }
        public string StatusDescricao { get; set; } = string.Empty;
        public string? ObservacoesReserva { get; set; }
        public DateTime? DataHoraEntrega { get; set; }
        public DateTime? DataHoraDevolucao { get; set; }
        public string? ResponsavelEntrega { get; set; }
        public string? ResponsavelDevolucao { get; set; }
    }
}
