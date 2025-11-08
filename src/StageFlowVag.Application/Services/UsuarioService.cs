using AutoMapper;
using StageFlowVag.Application.Interfaces;
using StageFlowVag.Communication.Requests.Usuarios;
using StageFlowVag.Communication.Responses.Usuarios;
using StageFlowVag.Domain.Entities.Usuarios;
using StageFlowVag.Domain.Interfaces;

namespace StageFlowVag.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UsuarioResponse> CriarAsync(UsuarioRequest request)
        {
            var usuario = _mapper.Map<Usuario>(request);
            usuario.CriadoEm = DateTime.UtcNow;
            usuario.IsActive = true;

            await _repository.AddAsync(usuario);
            await _repository.SaveChangesAsync();

            return _mapper.Map<UsuarioResponse>(usuario);
        }

        public async Task<UsuarioResponse?> ObterPorIdAsync(int id)
        {
            var usuario = await _repository.GetByIdAsync(id);
            return usuario is null ? null : _mapper.Map<UsuarioResponse>(usuario);
        }

        public async Task<IEnumerable<UsuarioResponse>> ObterTodosAsync()
        {
            var usuarios = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<UsuarioResponse>>(usuarios);
        }

        public async Task<UsuarioResponse> AtualizarAsync(int id, UsuarioRequest request)
        {
            var usuario = await _repository.GetByIdAsync(id)
                ?? throw new Exception("Usuário não encontrado.");

            _mapper.Map(request, usuario);  // Atualiza o usuário com os dados do request

            _repository.Update(usuario);
            await _repository.SaveChangesAsync();

            return _mapper.Map<UsuarioResponse>(usuario);
        }

        public async Task DeletarAsync(int id)
        {
            var usuario = await _repository.GetByIdAsync(id)
                ?? throw new Exception("Usuário não encontrado.");

            usuario.IsActive = false;
            _repository.Update(usuario);
            await _repository.SaveChangesAsync();
        }
    }
}
