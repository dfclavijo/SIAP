using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAP.Domain.Entities
{
    [Table("Professor", Schema = "dbo")]
    public class Professor
    {   [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ProfessorsId")]  
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public ICollection<Internship> Internships { get; set; }

    }
}
