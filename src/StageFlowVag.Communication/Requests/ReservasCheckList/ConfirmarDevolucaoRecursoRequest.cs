namespace StageFlowVag.Communication.Requests.ReservasCheckList
{
    public class ConfirmarDevolucaoRecursoRequest
    {
        public string ResponsavelDevolucao { get; set; } = string.Empty;
        public string? Observacoes { get; set; }
    }
}
