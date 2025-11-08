using StageFlowVag.Communication.Enums;

namespace StageFlowVag.Communication.Responses.Usuarios
{
    public class UsuarioResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Matricula { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Telefone { get; set; }

        public RoleUsuario Role { get; set; }
        public string RoleNome { get; set; } = string.Empty;

        public DepartamentoEnum? Departamento { get; set; }
        public string? DepartamentoNome { get; set; }

        public bool IsActive { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
