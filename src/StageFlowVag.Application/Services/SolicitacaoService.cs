using AutoMapper;
using StageFlowVag.Application.Interfaces;
using StageFlowVag.Communication.Requests.Solicitacoes;
using StageFlowVag.Communication.Responses.Solicitacoes;
using StageFlowVag.Domain.Entities.AtendimentosDepartamentos;
using StageFlowVag.Domain.Entities.Solicitacoes;
using StageFlowVag.Domain.Enums;
using StageFlowVag.Domain.Interfaces;

namespace StageFlowVag.Application.Services
{
    public class SolicitacaoService : ISolicitacaoService
    {
        private readonly ISolicitacaoRepository _solicitacaoRepository;
        private readonly IAtendimentoDepartamentoRepository _atendimentoRepository;
        private readonly IInsumoRepository _insumoRepository;
        private readonly IMapper _mapper;

        public SolicitacaoService(
            ISolicitacaoRepository solicitacaoRepository,
            IAtendimentoDepartamentoRepository atendimentoRepository,
            IInsumoRepository insumoRepository,
            IMapper mapper)
        {
            _solicitacaoRepository = solicitacaoRepository;
            _atendimentoRepository = atendimentoRepository;
            _insumoRepository = insumoRepository;
            _mapper = mapper;
        }

        public async Task<SolicitacaoResponse> CriarSolicitacaoAsync(SolicitacaoRequest request)
        {
            var solicitacao = _mapper.Map<Solicitacao>(request);
            solicitacao.CriadoEm = DateTime.UtcNow;
            solicitacao.IsActive = true;

            await _solicitacaoRepository.AddAsync(solicitacao);
            await _solicitacaoRepository.SaveChangesAsync();

            return _mapper.Map<SolicitacaoResponse>(solicitacao);
        }

        public async Task<SolicitacaoResponse?> ObterPorIdAsync(int id)
        {
            var solicitacao = await _solicitacaoRepository.GetDetalhadaAsync(id);
            return solicitacao is null ? null : _mapper.Map<SolicitacaoResponse>(solicitacao);
        }

        public async Task<IEnumerable<SolicitacaoResponse>> ObterTodasAsync()
        {
            var solicitacoes = await _solicitacaoRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<SolicitacaoResponse>>(solicitacoes);
        }

        public async Task<SolicitacaoResponse> AprovarSolicitacaoAsync(int id, AprovarSolicitacaoRequest request)
        {
            var solicitacao = await _solicitacaoRepository.GetByIdAsync(id)
                ?? throw new Exception("Solicitação não encontrada.");

            solicitacao.Aprovado = request.Aprovar;
            solicitacao.DataAprovacao = DateTime.UtcNow;
            solicitacao.AprovadoPorId = request.ViceReitorId;
            solicitacao.JustificativaRejeicao = request.JustificativaRejeicao;

            _solicitacaoRepository.Update(solicitacao);
            await _solicitacaoRepository.SaveChangesAsync();

            // Se aprovada → criar automaticamente os atendimentos
            if (request.Aprovar)
            {
                var departamentos = await IdentificarDepartamentosPorInsumos(solicitacao.Id);
                foreach (var dept in departamentos.Distinct())
                {
                    var atendimento = new AtendimentoDepartamento
                    {
                        SolicitacaoId = solicitacao.Id,
                        Departamento = dept,
                        Status = StatusAtendimentoEnum.Pendente,
                        CriadoEm = DateTime.UtcNow,
                        IsActive = true
                    };

                    await _atendimentoRepository.AddAsync(atendimento);
                }

                await _atendimentoRepository.SaveChangesAsync();
            }

            return _mapper.Map<SolicitacaoResponse>(solicitacao);
        }

        private async Task<IEnumerable<DepartamentoEnum>> IdentificarDepartamentosPorInsumos(int solicitacaoId)
        {
            var solicitacao = await _solicitacaoRepository.GetDetalhadaAsync(solicitacaoId);
            if (solicitacao == null)
                return Enumerable.Empty<DepartamentoEnum>();

            var insumosIds = solicitacao.Insumos.Select(x => x.InsumoId).ToList();
            var insumos = await _insumoRepository.FindAsync(i => insumosIds.Contains(i.Id));

            return insumos.Select(i => i.Departamento);
        }
    }
}
