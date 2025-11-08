using StageFlowVag.Communication.Enums.AudioVisualEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Communication.Requests.RecursosAudiosVisuais
{
    public class ConsultarDisponibilidadeRequest
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public TipoRecursoAudiovisual? TipoRecurso { get; set; }
    }
}
