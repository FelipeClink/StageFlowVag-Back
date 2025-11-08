using StageFlowVag.Communication.Enums.AudioVisualEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Communication.Requests.RecursosAudiosVisuais
{
    public class CriarRecursoAudiovisualRequest
    {
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public TipoRecursoAudiovisual Tipo { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public string? NumeroPatrimonio { get; set; }
        public string? Observacoes { get; set; }
    }
}
