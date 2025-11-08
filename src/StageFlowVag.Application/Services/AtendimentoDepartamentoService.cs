using AutoMapper;
using StageFlowVag.Application.Interfaces;
using StageFlowVag.Communication.Requests.AtendimentosDepartamentos;
using StageFlowVag.Communication.Responses.AtendimentosDepartamentos;
using StageFlowVag.Domain.Entities.AtendimentosDepartamentos;
using StageFlowVag.Domain.Enums;
using StageFlowVag.Domain.Interfaces;

namespace StageFlowVag.Application.Services
{
    public class AtendimentoDepartamentoService : IAtendimentoDepartamentoService
    {
        private readonly IAtendimentoDepartamentoRepository _repository;
        private readonly IMapper _mapper;

        public AtendimentoDepartamentoService(IAtendimentoDepartamentoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<AtendimentoDepartamentoResponse> IniciarAsync(AtendimentoDepartamentoRequest request)
        {
            var atendimento = _mapper.Map<AtendimentoDepartamento>(request);
            atendimento.Status = StatusAtendimentoEnum.EmAndamento;
            atendimento.DataInicio = DateTime.UtcNow;
            atendimento.IsActive = true;
            atendimento.CriadoEm = DateTime.UtcNow;

            await _repository.AddAsync(atendimento);
            await _repository.SaveChangesAsync();

            return _mapper.Map<AtendimentoDepartamentoResponse>(atendimento);
        }

        public async Task<AtendimentoDepartamentoResponse> AtualizarStatusAsync(int id, AtualizarStatusAtendimentoRequest request)
        {
            var atendimento = await _repository.GetByIdAsync(id)
                ?? throw new Exception("Atendimento não encontrado.");

            atendimento.Status = (StatusAtendimentoEnum)request.Status;
            atendimento.Observacoes = request.Observacoes;

            if (request.Status == Communication.Enums.StatusAtendimentoEnum.Concluido)
            {
                atendimento.DataConclusao = DateTime.UtcNow;
            }

            _repository.Update(atendimento);
            await _repository.SaveChangesAsync();

            return _mapper.Map<AtendimentoDepartamentoResponse>(atendimento);
        }

        public async Task<IEnumerable<AtendimentoDepartamentoResponse>> ObterPorDepartamentoAsync(DepartamentoEnum departamento)
        {
            var atendimentos = await _repository.GetByDepartamentoAsync(departamento);
            return _mapper.Map<IEnumerable<AtendimentoDepartamentoResponse>>(atendimentos);
        }
    }
}
