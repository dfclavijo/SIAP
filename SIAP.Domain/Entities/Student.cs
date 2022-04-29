using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAP.Domain.Entities
{

[Table("Student", Schema = "dbo")]
    public class Student : BaseEntity
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("DocumentId")]
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
        public University UniversityNavigation { get; set; }
        public ICollection<Internship> Internships { get; set; }

    }
}
