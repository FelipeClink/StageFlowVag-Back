namespace StageFlowVag.Communication.Requests.ReservasRecursos
{
    public class ConfirmarDevolucaoRecursoRequest
    {
        public string ResponsavelDevolucao { get; set; } = string.Empty;
        public string? Observacoes { get; set; }
    }
}
