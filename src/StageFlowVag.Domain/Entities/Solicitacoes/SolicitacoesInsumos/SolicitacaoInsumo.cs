using StageFlowVag.Domain.Base;
using StageFlowVag.Domain.Entities.Insumos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Domain.Entities.Solicitacoes.SolicitacoesInsumos
{
    public class SolicitacaoInsumo : BaseEntity
    {
        public int SolicitacaoId { get; set; }
        public Solicitacao Solicitacao { get; set; } = null!;

        public int InsumoId { get; set; }
        public Insumo Insumo { get; set; } = null!;

        public int Quantidade { get; set; }
        public string? Observacoes { get; set; }
    }
}
