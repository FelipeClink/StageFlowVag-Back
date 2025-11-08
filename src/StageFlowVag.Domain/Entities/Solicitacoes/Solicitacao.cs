using StageFlowVag.Domain.Base;
using StageFlowVag.Domain.Entities.AtendimentosDepartamentos;
using StageFlowVag.Domain.Entities.Blocos;
using StageFlowVag.Domain.Entities.Solicitacoes.SolicitacoesInsumos;
using StageFlowVag.Domain.Entities.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Domain.Entities.Solicitacoes
{
    public class Solicitacao : BaseEntity
    {
        public string NomeEvento { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public DateTime DataEvento { get; set; }
        public string Local { get; set; } = string.Empty;
        public int PublicoEstimado { get; set; }

        public bool? Aprovado { get; set; } 
        public DateTime? DataAprovacao { get; set; }
        public int? AprovadoPorId { get; set; } 
        public string? JustificativaRejeicao { get; set; }

        public int SolicitanteId { get; set; }
        public Usuario Solicitante { get; set; } = null!;

        public int? BlocoId { get; set; }
        public Bloco? Bloco { get; set; }

        // Relacionamentos
        public ICollection<SolicitacaoInsumo> Insumos { get; set; } = new List<SolicitacaoInsumo>();
        public ICollection<AtendimentoDepartamento> Atendimentos { get; set; } = new List<AtendimentoDepartamento>();
    }
}
