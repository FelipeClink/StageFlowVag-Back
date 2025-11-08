using System.ComponentModel.DataAnnotations;

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

