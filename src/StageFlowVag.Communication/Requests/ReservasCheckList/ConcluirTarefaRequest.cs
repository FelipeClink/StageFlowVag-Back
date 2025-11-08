namespace StageFlowVag.Communication.Requests.ReservasCheckList
{
    public class ConcluirTarefaRequest
    {
        public string ResponsavelNome { get; set; } = string.Empty;
        public string? ObservacoesConclusao { get; set; }
    }
}
