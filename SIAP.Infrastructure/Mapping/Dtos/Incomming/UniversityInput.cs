using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAP.Infrastructure.Mapping.Dtos.Incomming
{
    public class UniversityInput
    {
        public int Id { get; set; }  
        public string Name { get; set; }
        public ICollection<StudentInput> Students { get; set; }
    }
}