using StageFlowVag.Domain.Base;
using StageFlowVag.Domain.Entities.Solicitacoes;
using StageFlowVag.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Domain.Entities.Blocos
{
    public class DisponibilidadeBloco : BaseEntity
    {
        public int BlocoId { get; set; }
        public Bloco Bloco { get; set; } = null!;

        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }

        public StatusBlocoEnum Status { get; set; }

        // Se reservado, qual solicitação
        public int? SolicitacaoId { get; set; }
        public Solicitacao? Solicitacao { get; set; }

        public string? Observacoes { get; set; }
    }    
}

