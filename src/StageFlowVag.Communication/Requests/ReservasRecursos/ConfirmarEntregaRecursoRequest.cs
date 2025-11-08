namespace StageFlowVag.Communication.Requests.ReservasRecursos
{
    public class ConfirmarEntregaRecursoRequest
    {
        public string ResponsavelEntrega { get; set; } = string.Empty;
        public string? Observacoes { get; set; }
    }
}
