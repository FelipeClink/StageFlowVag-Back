using StageFlowVag.Communication.Enums;

namespace StageFlowVag.Communication.Responses.Solicitacoes
{
    public class SolicitacaoResponse
    {
        public int Id { get; set; }
        public string NomeEvento { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public DateTime DataEvento { get; set; }
        public string Local { get; set; } = string.Empty;
        public int PublicoEstimado { get; set; }

        public string StatusAprovacao { get; set; } = "Pendente"; // Pendente, Aprovado, Rejeitado
        public DateTime? DataAprovacao { get; set; }
        public string? JustificativaRejeicao { get; set; }

        public int SolicitanteId { get; set; }
        public string NomeSolicitante { get; set; } = string.Empty;
        public string EmailSolicitante { get; set; } = string.Empty;

        // Bloco
        public int? BlocoId { get; set; }
        public string? NomeBloco { get; set; }

        // Insumos
        public List<InsumoSolicitacaoResponse> Insumos { get; set; } = new();

        // Atendimentos
        public List<AtendimentoResponse> Atendimentos { get; set; } = new();

        public DateTime CriadoEm { get; set; }
    }

    public class InsumoSolicitacaoResponse
    {
        public int InsumoId { get; set; }
        public string NomeInsumo { get; set; } = string.Empty;
        public DepartamentoEnum Departamento { get; set; }
        public string DepartamentoNome { get; set; } = string.Empty;
        public int Quantidade { get; set; }
        public string? Observacoes { get; set; }
    }

    public class AtendimentoResponse
    {
        public int Id { get; set; }
        public DepartamentoEnum Departamento { get; set; }
        public string DepartamentoNome { get; set; } = string.Empty;
        public StatusAtendimentoEnum Status { get; set; }
        public string StatusNome { get; set; } = string.Empty;
        public string? NomeResponsavel { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataConclusao { get; set; }
        public string? Observacoes { get; set; }
    }
}