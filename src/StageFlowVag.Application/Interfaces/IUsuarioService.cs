using StageFlowVag.Communication.Requests.Usuarios;
using StageFlowVag.Communication.Responses.Usuarios;

namespace StageFlowVag.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioResponse> CriarAsync(UsuarioRequest request);
        Task<UsuarioResponse?> ObterPorIdAsync(int id);
        Task<IEnumerable<UsuarioResponse>> ObterTodosAsync();
        Task<UsuarioResponse> AtualizarAsync(int id, UsuarioRequest request);
        Task DeletarAsync(int id);
    }
}
