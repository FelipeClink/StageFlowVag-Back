using StageFlowVag.Communication.Enums;
using System.ComponentModel.DataAnnotations;

namespace StageFlowVag.Communication.Requests.AtendimentosDepartamentos
{
    public class AtendimentoDepartamentoRequest
    {
        public int SolicitacaoId { get; set; }

        public DepartamentoEnum Departamento { get; set; }

        public int? ResponsavelId { get; set; }

        public string? Observacoes { get; set; }
    }

    public class AtualizarStatusAtendimentoRequest
    {
        public StatusAtendimentoEnum Status { get; set; }

        public string? Observacoes { get; set; }
    }
}
