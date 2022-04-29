using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIAP.Infrastructure.Mapping.Dtos.Incomming
{
    public class SupervisorInput
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public string CellPhone { get; set; }
    public string Email { get; set; }       
    public string Position { get; set; }
    //public ICollection<InternshipInput> Internships { get; set; }
    }
}