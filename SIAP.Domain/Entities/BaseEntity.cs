using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAP.Domain.Entities
{
    
    public class BaseEntity
    {
        public Guid Index { get; set; } = Guid.NewGuid();
        public bool IsActive { get; set; } = true;
        public DateTime AddedDate { get; set; } = DateTime.UtcNow;
        public DateTime UpdateDate { get; set; } = DateTime.UtcNow;
                
    }
}
