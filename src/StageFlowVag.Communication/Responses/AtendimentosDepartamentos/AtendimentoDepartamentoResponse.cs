using StageFlowVag.Communication.Enums;

namespace StageFlowVag.Communication.Responses.AtendimentosDepartamentos
{
    public class AtendimentoDepartamentoResponse
    {
        public int Id { get; set; }
        public int SolicitacaoId { get; set; }
        public string NomeEvento { get; set; } = string.Empty;

        public DepartamentoEnum Departamento { get; set; }
        public string DepartamentoNome { get; set; } = string.Empty;

        public StatusAtendimentoEnum Status { get; set; }
        public string StatusNome { get; set; } = string.Empty;

        public int? ResponsavelId { get; set; }
        public string? NomeResponsavel { get; set; }

        public DateTime? DataInicio { get; set; }
        public DateTime? DataConclusao { get; set; }
        public string? Observacoes { get; set; }

        public bool IsActive { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
