using StageFlowVag.Communication.Enums;
using System.ComponentModel.DataAnnotations;

namespace StageFlowVag.Communication.Requests.Usuarios
{
    public class UsuarioRequest
    {
        public string Nome { get; set; } = string.Empty;

        public string Matricula { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string? Telefone { get; set; }

        public RoleUsuario Role { get; set; }

        public DepartamentoEnum? Departamento { get; set; }
    }
}
