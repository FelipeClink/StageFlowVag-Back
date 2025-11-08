using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Domain.Base
{
    public interface IBaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        DateTime CriadoEm { get; set; }
        DateTime? AlteradoEm { get; set; }
        DateTime? DeletadoEm { get; set; }
    }
}
