using StageFlowVag.Domain.Base;
using StageFlowVag.Domain.Entities.AtendimentosDepartamentos;
using StageFlowVag.Domain.Entities.Solicitacoes;
using StageFlowVag.Domain.Enums;

namespace StageFlowVag.Domain.Entities.Usuarios
{
    public class Usuario : BaseEntity
    {
        public string Nome { get; set; } = string.Empty;
        public string Matricula { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public RoleUsuario Role { get; set; }
        public string? Telefone { get; set; }
        public string? Departamento { get; set; }

        // Relacionamentos
        public ICollection<Solicitacao> Solicitacoes { get; set; } = new List<Solicitacao>();
        public ICollection<AtendimentoDepartamento> Atendimentos { get; set; } = new List<AtendimentoDepartamento>();
    }
}