using AutoMapper;
using StageFlowVag.Application.Interfaces;
using StageFlowVag.Communication.Requests.Insumos;
using StageFlowVag.Communication.Responses.Insumos;
using StageFlowVag.Domain.Entities.Insumos;
using StageFlowVag.Domain.Enums;
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

        public async Task<InsumoResponse> CriarAsync(InsumoRequest request)
        {
            var entity = _mapper.Map<Insumo>(request);
            entity.CriadoEm = DateTime.UtcNow;
            entity.IsActive = true;

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<InsumoResponse>(entity);
        }


        public async Task<IEnumerable<InsumoResponse>> ObterTodosAsync(int? departamento)
        {
            IEnumerable<Insumo> insumos;

            if (departamento.HasValue)
            {

                insumos = await _repository.GetByDepartamentoAsync((DepartamentoEnum)departamento.Value);
            }
            else
            {

                insumos = await _repository.GetAllAsync();
            }

            // 3. Mapeamos o resultado, não importa qual caminho foi usado
            return _mapper.Map<IEnumerable<InsumoResponse>>(insumos);
        }
        // 
        // --- FIM DA CORREÇÃO ---
        // 

        public async Task<InsumoResponse?> ObterPorIdAsync(int id)
        {
            var insumo = await _repository.GetByIdAsync(id);
            return _mapper.Map<InsumoResponse>(insumo);
        }

        
        public async Task<IEnumerable<InsumoResponse>> ObterPorDepartamentoAsync(int departamento)
        {
            var insumos = await _repository.GetByDepartamentoAsync((DepartamentoEnum)departamento);
            return _mapper.Map<IEnumerable<InsumoResponse>>(insumos);
        }
        
        
    }
}