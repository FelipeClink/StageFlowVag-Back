namespace StageFlowVag.Communication.Requests.Eventos
{
    public class RecursoSolicitadoRequest
    {
        public int RecursoId { get; set; }
        public int Quantidade { get; set; }
        public string? Observacoes { get; set; }
    }
}
