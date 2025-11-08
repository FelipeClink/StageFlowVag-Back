using StageFlowVag.Domain.Base;
using StageFlowVag.Domain.Enums;

namespace StageFlowVag.Domain.Entities
{
    public class Usuario : BaseEntity
    {
        public string Matricula { get; set; }
        public string Nome { get; set; } 
        public string Senha { get; set; }
        public string Email { get; set; }
        public UsuarioEnum Role { get; set; }
    }
}
