using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAP.Infrastructure.Mapping.Dtos.Incomming
{
    public class FeeInput
    {
        public int Id { get; set; }
        public int PaymentId { get; set; }
        public float Amount { get; set; }
        public DateTime date { get; set; }
    }
}