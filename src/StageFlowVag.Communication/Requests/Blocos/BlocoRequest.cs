using System.ComponentModel.DataAnnotations;

namespace StageFlowVag.Communication.Requests.Blocos
{
    public class BlocoRequest
    {
        public string Nome { get; set; } = string.Empty;

        public string? Descricao { get; set; }

        public int Capacidade { get; set; }

        public string? Localizacao { get; set; }

        public string? Observacoes { get; set; }
    }
}
