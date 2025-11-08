using StageFlowVag.Communication.Enums;

namespace StageFlowVag.Communication.Responses.Insumos
{
    public class InsumoResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public DepartamentoEnum Departamento { get; set; }
        public string DepartamentoNome { get; set; } = string.Empty;
        public int QuantidadeDisponivel { get; set; }
        public string? Observacoes { get; set; }
        public bool IsActive { get; set; }
    }
}