using AutoMapper;
using StageFlowVag.Communication.Requests;
using StageFlowVag.Communication.Requests.Insumos;
using StageFlowVag.Communication.Requests.Solicitacoes;
using StageFlowVag.Communication.Responses;
using StageFlowVag.Communication.Responses.Insumos;
using StageFlowVag.Communication.Responses.Solicitacoes;
using StageFlowVag.Domain.Entities.Insumos;
using StageFlowVag.Domain.Entities.Solicitacoes;

namespace StageFlowVag.Application.Mappings
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<SolicitacaoRequest, Solicitacao>().ReverseMap();
            CreateMap<Solicitacao, SolicitacaoResponse>().ReverseMap();

            CreateMap<InsumoRequest, Insumo>().ReverseMap();
            CreateMap<Insumo, InsumoResponse>().ReverseMap();
        }
    }
}
