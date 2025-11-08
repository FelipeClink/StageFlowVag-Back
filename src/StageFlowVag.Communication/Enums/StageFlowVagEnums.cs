namespace StageFlowVag.Communication.Enums
{
    public enum RoleUsuario
    {
        Professor = 1,
        Coordenador = 2,
        ViceReitor = 3,
        Audiovisual = 4,
        Cerimonial = 5,
        Marketing = 6,
        Administrador = 7
    }

    public enum DepartamentoEnum
    {
        Audiovisual = 1,
        Cerimonial = 2,
        Marketing = 3
    }

    public enum StatusAtendimentoEnum
    {
        Pendente = 1,
        EmAndamento = 2,
        Concluido = 3,
        Cancelado = 4
    }

    public enum StatusBlocoEnum
    {
        Disponivel = 1,
        Reservado = 2,
        Manutencao = 3,
        Indisponivel = 4
    }
}