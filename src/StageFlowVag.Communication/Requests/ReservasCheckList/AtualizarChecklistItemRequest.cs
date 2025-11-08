using StageFlowVag.Communication.Enums.AudioVisualEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Communication.Requests.ReservasCheckList
{
    public class AtualizarChecklistItemRequest
    {
        public string Titulo { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public SetorResponsavel SetorResponsavel { get; set; }
        public PrioridadeTarefa Prioridade { get; set; }
        public StatusTarefa Status { get; set; }
        public DateTime? DataLimite { get; set; }
        public string? ResponsavelNome { get; set; }
    }
}
