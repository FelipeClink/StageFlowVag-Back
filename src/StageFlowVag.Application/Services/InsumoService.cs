using AutoMapper;
using StageFlowVag.Application.Interfaces;
using StageFlowVag.Communication.Requests;
using StageFlowVag.Communication.Requests.Insumos;
using StageFlowVag.Communication.Responses;
using StageFlowVag.Communication.Responses.Insumos;
using StageFlowVag.Domain.Entities.Insumos;
using StageFlowVag.Domain.Interfaces;

namespace StageFlowVag.Application.Services
{
    public class InsumoService : IInsumoService
    {
        private readonly IInsumoRepository _repository;
        private readonly IMapper _mapper;

        public InsumoService(IInsumoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<InsumoResponse> CriarAsync(CriarInsumoRequest request)
        {
            var entity = _mapper.Map<Insumo>(request);
            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<InsumoResponse>(entity);
        }

        public async Task<IEnumerable<InsumoResponse>> ObterPorDepartamentoAsync(int departamento)
        {
            var insumos = await _repository.GetByDepartamentoAsync((Domain.Enums.DepartamentoEnum)departamento);
            return _mapper.Map<IEnumerable<InsumoResponse>>(insumos);
        }
    }
}
