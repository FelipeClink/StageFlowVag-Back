namespace StageFlowVag.Communication.Responses.Solicitacoes
{
    public class AprovarSolicitacaoResponse
    {
        public int SolicitacaoId { get; set; }
        public bool Aprovado { get; set; }
        public string StatusAprovacao => Aprovado ? "Aprovado" : "Rejeitado";
        public DateTime DataAprovacao { get; set; }
        public int ViceReitorId { get; set; }
        public string? JustificativaRejeicao { get; set; }
    }
}
