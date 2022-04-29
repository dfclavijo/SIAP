using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAP.Infrastructure.Mapping.Dtos.Incomming
{
    public class StudentInput
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Cedula { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Faculty { get; set; }
        public string Program { get; set; }
        public string University { get; set; }
        public int Eps { get; set; } //Enum
        //public ICollection<InternshipInput> Internships { get; set; }
    }
}