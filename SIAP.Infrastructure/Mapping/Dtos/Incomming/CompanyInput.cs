using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAP.Infrastructure.Mapping.Dtos.Incomming
{
    public class CompanyInput
    {
        public int Id { get; set; }
        public string Nit { get; set; }
        public string Name { get; set; }
        public string LegalNature { get; set;}
        public ICollection<AgreementInput> Aggreements { get; set; }
    }
}