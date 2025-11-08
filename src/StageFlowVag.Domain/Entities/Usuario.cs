using StageFlowVag.Domain.Base;
using StageFlowVag.Domain.Enums;

namespace StageFlowVag.Domain.Entities
{
    public class Usuario : BaseEntity
    {
        public string Matricula { get; set; } = string.Empty;
        public string CodigoFuncionario { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty; 
        public string Email { get; set; } = string.Empty;
        public UsuarioEnum Role { get; set; }
    }
}
