using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAP.Infrastructure.Mapping.Dtos.Incomming
{
    public class Payment
    {
        public int Id { get; set; }
        public int InternshipId { get; set; }
        public float Total { get; set; }
        public int CdpNumber { get; set; }
        public ICollection<FeeInput> Fees { get; set; }
    }
}