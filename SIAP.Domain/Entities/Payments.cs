using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAP.Domain.Entities
{
    [Table("Payment", Schema = "dbo")]      
    public class Payment
    {                
        public int Id { get; set; }
        public int InternshipId { get; set; }
        public float Total { get; set; }
        public int CdpNumber { get; set; }
        public Internship Internships { get; set; }
        public ICollection<Fee> Fees { get; set; }
    }
}
