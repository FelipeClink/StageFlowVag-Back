using StageFlowVag.Domain.Base;
using StageFlowVag.Domain.Enums.AudioVisualEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Domain.Entities.Audiovisual
{
    public class RecursoAudioVisual : BaseEntity
    {
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public TipoRecursoAudiovisual Tipo { get; set; }
        public StatusRecurso Status { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public string? NumeroPatrimonio { get; set; }
        public string? Observacoes { get; set; }

        public ICollection<ReservaRecurso> Reservas { get; set; } = new List<ReservaRecurso>();

    }
}
