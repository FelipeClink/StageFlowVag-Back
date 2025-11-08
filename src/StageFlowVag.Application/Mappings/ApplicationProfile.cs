using AutoMapper;
using StageFlowVag.Communication.Requests.AtendimentosDepartamentos;
using StageFlowVag.Communication.Requests.Blocos;
using StageFlowVag.Communication.Requests.Insumos;
using StageFlowVag.Communication.Requests.Solicitacoes;
using StageFlowVag.Communication.Requests.Usuarios;
using StageFlowVag.Communication.Responses.AtendimentosDepartamentos;
using StageFlowVag.Communication.Responses.Blocos;
using StageFlowVag.Communication.Responses.Insumos;
using StageFlowVag.Communication.Responses.Solicitacoes;
using StageFlowVag.Communication.Responses.Usuarios;
using StageFlowVag.Domain.Entities.AtendimentosDepartamentos;
using StageFlowVag.Domain.Entities.Blocos;
using StageFlowVag.Domain.Entities.Insumos;
using StageFlowVag.Domain.Entities.Solicitacoes;
using StageFlowVag.Domain.Entities.Usuarios;

namespace StageFlowVag.Application.Mappings
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            // Mapeamento para Usuario
            CreateMap<UsuarioRequest, Usuario>();  // UsuarioRequest → Usuario (Cadastro)
            CreateMap<Usuario, UsuarioResponse>();  // Usuario → UsuarioResponse (Resposta da API)

            // Mapeamento para Solicitacao
            CreateMap<SolicitacaoRequest, Solicitacao>();  // SolicitacaoRequest → Solicitacao
            CreateMap<Solicitacao, SolicitacaoResponse>();  // Solicitacao → SolicitacaoResponse

            // Mapeamento para Insumo
            CreateMap<InsumoRequest, Insumo>();  // InsumoRequest → Insumo
            CreateMap<Insumo, InsumoResponse>();  // Insumo → InsumoResponse

            // Mapeamento para Bloco
            CreateMap<BlocoRequest, Bloco>();  // BlocoRequest → Bloco
            CreateMap<Bloco, BlocoResponse>();  // Bloco → BlocoResponse

            // Mapeamento para AtendimentoDepartamento
            CreateMap<AtendimentoDepartamentoRequest, AtendimentoDepartamento>();  // AtendimentoDepartamentoRequest → AtendimentoDepartamento
            CreateMap<AtendimentoDepartamento, AtendimentoDepartamentoResponse>();  // AtendimentoDepartamento → AtendimentoDepartamentoResponse
        }
    }
}
