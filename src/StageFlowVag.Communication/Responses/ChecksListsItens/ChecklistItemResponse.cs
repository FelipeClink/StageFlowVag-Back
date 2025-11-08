using StageFlowVag.Communication.Enums.AudioVisualEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Communication.Responses.ChecksListsItens
{
    public class ChecklistItemResponse
    {
        public int Id { get; set; }
        public int EventoId { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public SetorResponsavel SetorResponsavel { get; set; }
        public string SetorResponsavelDescricao { get; set; } = string.Empty;
        public PrioridadeTarefa Prioridade { get; set; }
        public string PrioridadeDescricao { get; set; } = string.Empty;
        public StatusTarefa Status { get; set; }
        public string StatusDescricao { get; set; } = string.Empty;
        public DateTime? DataLimite { get; set; }
        public DateTime? DataConclusao { get; set; }
        public string? ResponsavelNome { get; set; }
        public string? ObservacoesConclusao { get; set; }
        public bool GeradoAutomaticamente { get; set; }
        public bool Atrasada { get; set; }
    }

}
