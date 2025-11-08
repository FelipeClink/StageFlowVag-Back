using StageFlowVag.Communication.Enums.AudioVisualEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Communication.Requests.ReservasRecursos
{
    public class AtualizarReservaRecursoRequest
    {
        public int Quantidade { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public StatusReserva Status { get; set; }
        public string? ObservacoesReserva { get; set; }
    }
}
