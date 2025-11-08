namespace StageFlowVag.Communication.Requests.Solicitacoes
{
    public class CriarSolicitacaoRequest
    {
        public string NomeEvento { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public DateTime DataEvento { get; set; }
        public string Local { get; set; } = string.Empty;
        public int PublicoEstimado { get; set; }
        public int SolicitanteId { get; set; }
        public int? BlocoId { get; set; }

        public List<InsumoSolicitadoRequest> Insumos { get; set; } = new();
    }

    public class InsumoSolicitadoRequest
    {
        public int InsumoId { get; set; }
        public int Quantidade { get; set; }
        public string? Observacoes { get; set; }
    }
}