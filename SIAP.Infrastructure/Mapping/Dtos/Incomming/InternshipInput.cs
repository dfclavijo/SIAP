using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAP.Infrastructure.Mapping.Dtos.Incomming
{
    public class InternshipInput
    {
        public int Id { get; set; }
        public int type { get; set; }
        public int StudentId { get; set; }
        public int? ProfessorId { get; set; }
        public int AggrementId { get; set; }
        public string Dependency { get; set; }
        public int Status { get; set; } //Enum
        public string Modality { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime EndDate { get; set; }
        public string EntryTime { get; set; }
        public string ExitTime { get; set; }
        public int WeekHours { get; set; }
        public bool IsPaid { get; set; }
        public string GeneralGoal { get; set; }
        public string SpecificGoals { get; set; }
        public string Observations { get; set; }
    }
}