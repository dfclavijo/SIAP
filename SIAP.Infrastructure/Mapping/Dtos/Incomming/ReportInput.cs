using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAP.Infrastructure.Mapping.Dtos.Incomming
{
    public class ReportInput
    {
        public int Id { get; set; }
        public int PracticaId { get; set; } 
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int InternshipId { get; set; }
    }
}