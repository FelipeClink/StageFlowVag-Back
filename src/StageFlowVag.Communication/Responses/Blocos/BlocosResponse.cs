using StageFlowVag.Communication.Enums;

namespace StageFlowVag.Communication.Responses.Blocos
{
    public class BlocoResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public int Capacidade { get; set; }
        public string? Localizacao { get; set; }
        public string? Observacoes { get; set; }

        public bool IsActive { get; set; }

        public List<DisponibilidadeBlocoResponse> Disponibilidades { get; set; } = new();
    }

    public class DisponibilidadeBlocoResponse
    {
        public int Id { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public StatusBlocoEnum Status { get; set; }
        public string StatusNome { get; set; } = string.Empty;
        public string? Observacoes { get; set; }
    }
}
