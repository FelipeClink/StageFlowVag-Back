using StageFlowVag.Communication.Enums;

namespace StageFlowVag.Communication.Responses.Insumos
{
    public class InsumoSimplificadoResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public DepartamentoEnum Departamento { get; set; }
        public string DepartamentoNome { get; set; } = string.Empty;
    }
}
