using StageFlowVag.Communication.Enums.AudioVisualEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Communication.Responses.Eventos
{
    public class DisponibilidadeRecursoResponse
    {
        public Guid RecursoId { get; set; }
        public string NomeRecurso { get; set; } = string.Empty;
        public TipoRecursoAudiovisual Tipo { get; set; }
        public int QuantidadeTotal { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public int QuantidadeReservada { get; set; }
        public List<PeriodoReservadoResponse> PeriodosReservados { get; set; } = new();
    }
}
