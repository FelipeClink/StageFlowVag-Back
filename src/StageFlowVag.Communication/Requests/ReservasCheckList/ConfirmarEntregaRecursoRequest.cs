using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Communication.Requests.ReservasCheckList
{
    public class ConfirmarEntregaRecursoRequest
    {
        public string ResponsavelEntrega { get; set; } = string.Empty;
        public string? Observacoes { get; set; }
    }
}
