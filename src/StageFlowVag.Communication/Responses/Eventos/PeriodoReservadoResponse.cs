using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Communication.Responses.Eventos
{
    public class PeriodoReservadoResponse
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public int Quantidade { get; set; }
        public string TituloEvento { get; set; } = string.Empty;
    }
}
