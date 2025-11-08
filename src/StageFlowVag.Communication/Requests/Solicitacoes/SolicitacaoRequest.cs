using System.ComponentModel.DataAnnotations;

namespace StageFlowVag.Communication.Requests.Solicitacoes
{
    public class SolicitacaoRequest
    {
        public string NomeEvento { get; set; } = string.Empty;

        public string? Descricao { get; set; }

        public DateTime DataEvento { get; set; }

        public string Local { get; set; } = string.Empty;

        public int PublicoEstimado { get; set; }

        public int SolicitanteId { get; set; }

        public int? BlocoId { get; set; }

        public List<SolicitacaoInsumoRequest> Insumos { get; set; } = new();
    }
}
