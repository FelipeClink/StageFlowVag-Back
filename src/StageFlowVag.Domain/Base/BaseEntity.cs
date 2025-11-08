using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageFlowVag.Domain.Base
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;

        public DateTime CriadoEm { get; set; } = DateTime.UtcNow;

        public DateTime? AlteradoEm { get; set; }

        public DateTime? DeletadoEm { get; set; }
    }
}
