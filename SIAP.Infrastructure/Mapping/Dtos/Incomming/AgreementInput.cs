using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAP.Infrastructure.Mapping.Dtos.Incomming
{
    public class AgreementInput
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int CompanyId { get; set; }
        public string Observations { get; set; }
        public string Name { get; set; }
        public string SupervisorName { get; set; }
        public string Extension { get; set; }
        public string Term { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; } // TODO Enum
        public string Object { get; set; }
        public string Secop { get; set; }
        public string RegisteredNumber { get; set; }
        public string Liquidation { get; set; }
        public decimal Amount { get; set; }
        public String Petitioner { get; set; }
        public ICollection<InternshipInput> Internships { get; set; }
    }
}