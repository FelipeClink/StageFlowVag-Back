using AutoMapper;
using StageFlowVag.Application.Interfaces;
using StageFlowVag.Communication.Requests.Blocos;
using StageFlowVag.Communication.Responses.Blocos;
using StageFlowVag.Domain.Entities.Blocos;
using StageFlowVag.Domain.Interfaces;

namespace StageFlowVag.Application.Services
{
    public class BlocoService : IBlocoService
    {
        private readonly IBlocoRepository _repository;
        private readonly IMapper _mapper;

        public BlocoService(IBlocoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<BlocoResponse> CriarAsync(BlocoRequest request)
        {
            var bloco = _mapper.Map<Bloco>(request);
            bloco.CriadoEm = DateTime.UtcNow;
            bloco.IsActive = true;

            await _repository.AddAsync(bloco);
            await _repository.SaveChangesAsync();

            return _mapper.Map<BlocoResponse>(bloco);
        }

        public async Task<IEnumerable<BlocoResponse>> ObterTodosAsync()
        {
            var blocos = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<BlocoResponse>>(blocos);
        }

        public async Task<BlocoResponse?> ObterPorIdAsync(int id)
        {
            var bloco = await _repository.GetByIdAsync(id);
            return _mapper.Map<BlocoResponse>(bloco);
        }

        public async Task<IEnumerable<BlocoResponse>> ObterDisponiveisAsync(DateTime inicio, DateTime fim)
        {
            var blocos = await _repository.GetDisponiveisAsync(inicio, fim);
            return _mapper.Map<IEnumerable<BlocoResponse>>(blocos);
        }

        public async Task<IEnumerable<BlocoResponse>> ObterPorCapacidadeAsync(int capacidade)
        {
            var blocos = await _repository.GetByMinCapacidadeAsync(capacidade);
            return _mapper.Map<IEnumerable<BlocoResponse>>(blocos);
        }
    }
}
