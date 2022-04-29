using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIAP.Domain.Entities
{
    public class Report
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ReportId")]
        
        public int Id { get; set; }
        public int PracticaId { get; set; } 
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int InternshipId { get; set; }
        public Internship Internships { get; set; }
    }
}