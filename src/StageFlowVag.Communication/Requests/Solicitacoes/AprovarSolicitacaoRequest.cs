namespace StageFlowVag.Communication.Requests.Solicitacoes
{
    public class AprovarSolicitacaoRequest
    {
        public bool Aprovar { get; set; } // true = aprovar, false = rejeitar
        public int ViceReitorId { get; set; }
        public string? JustificativaRejeicao { get; set; }
    }
}