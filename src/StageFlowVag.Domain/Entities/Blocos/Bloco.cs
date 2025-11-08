using StageFlowVag.Domain.Base;
using StageFlowVag.Domain.Entities.Solicitacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Domain.Entities.Blocos
{
    public class Bloco : BaseEntity
    {
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public int Capacidade { get; set; }
        public string? Localizacao { get; set; }
        public string? Observacoes { get; set; }

        public ICollection<DisponibilidadeBloco> Disponibilidades { get; set; } = new List<DisponibilidadeBloco>();
        public ICollection<Solicitacao> Solicitacoes { get; set; } = new List<Solicitacao>();
    }
}
