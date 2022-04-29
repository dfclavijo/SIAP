using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAP.Infrastructure.Mapping.Dtos.Incomming
{
    public class InternshipRequestInput
    {
        public StudentInput Student { get; set; }
        public SupervisorInput Supervisor { get; set; }
        public InternshipInput Internship { get; set; }
        public ProductInput Products { get; set; }
        public ReportInput Reports { get; set; }    
        public Payment MyProperty { get; set; }
        //public DocumentsInput Documents { get; set; }
        
    }
}