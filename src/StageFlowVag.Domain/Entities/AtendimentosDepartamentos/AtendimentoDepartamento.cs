using StageFlowVag.Domain.Base;
using StageFlowVag.Domain.Entities.Solicitacoes;
using StageFlowVag.Domain.Entities.Usuarios;
using StageFlowVag.Domain.Enums;

namespace StageFlowVag.Domain.Entities.AtendimentosDepartamentos
{
    public class AtendimentoDepartamento : BaseEntity
    {
        public int SolicitacaoId { get; set; }
        public Solicitacao Solicitacao { get; set; } = null!;

        public DepartamentoEnum Departamento { get; set; }
        public StatusAtendimentoEnum Status { get; set; }

        // Responsável pelo atendimento
        public int? ResponsavelId { get; set; }
        public Usuario? Responsavel { get; set; }

        public DateTime? DataInicio { get; set; }
        public DateTime? DataConclusao { get; set; }
        public string? Observacoes { get; set; }
    }
}
