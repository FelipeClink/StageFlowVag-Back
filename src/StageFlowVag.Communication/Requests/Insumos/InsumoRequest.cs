using StageFlowVag.Communication.Enums;
using System.ComponentModel.DataAnnotations;

namespace StageFlowVag.Communication.Requests.Insumos
{
    public class InsumoRequest
    {
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public DepartamentoEnum Departamento { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public string? Observacoes { get; set; }
    }
}
