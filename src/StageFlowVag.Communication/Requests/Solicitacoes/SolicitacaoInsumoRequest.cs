using System.ComponentModel.DataAnnotations;

namespace StageFlowVag.Communication.Requests.Solicitacoes
{
    public class SolicitacaoInsumoRequest
    {
        public int InsumoId { get; set; }

        public int Quantidade { get; set; }

        public string? Observacoes { get; set; }
    }
}
