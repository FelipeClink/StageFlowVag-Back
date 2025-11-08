using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Communication.Requests.ReservasRecursos
{
    public class CriarReservaRecursoRequest
    {
        public int EventoId { get; set; }
        public int RecursoId { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public string? ObservacoesReserva { get; set; }
    }
}
