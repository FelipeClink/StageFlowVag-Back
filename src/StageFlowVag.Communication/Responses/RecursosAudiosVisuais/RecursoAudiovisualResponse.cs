using StageFlowVag.Communication.Enums.AudioVisualEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Communication.Responses.RecursosAudiosVisuais
{
    public class RecursoAudiovisualResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public TipoRecursoAudiovisual Tipo { get; set; }
        public string TipoDescricao { get; set; } = string.Empty;
        public StatusRecurso Status { get; set; }
        public string StatusDescricao { get; set; } = string.Empty;
        public int QuantidadeDisponivel { get; set; }
        public int QuantidadeEmUso { get; set; }
        public string? NumeroPatrimonio { get; set; }
        public string? Observacoes { get; set; }
    }
}
