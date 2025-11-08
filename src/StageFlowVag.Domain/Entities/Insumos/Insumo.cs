using StageFlowVag.Domain.Base;
using StageFlowVag.Domain.Entities.Solicitacoes.SolicitacoesInsumos;
using StageFlowVag.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Domain.Entities.Insumos
{
    public class Insumo : BaseEntity
    {
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public DepartamentoEnum Departamento { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public string? Observacoes { get; set; }

        public ICollection<SolicitacaoInsumo> SolicitacaoInsumos { get; set; } = new List<SolicitacaoInsumo>();
    }
}
