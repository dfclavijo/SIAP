using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIAP.Domain.Entities
{
    public class VisitReport
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("VisitReportId")]
        public int Id { get; set; }
        public int PracticaId { get; set; }
        public DateTime Date { get; set; }
        public Internship Internships { get; set; }
    }
}