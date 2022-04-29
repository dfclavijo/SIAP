using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAP.Domain.Entities
{
    public class University
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("UniversityId")]

        public int Id { get; set; }  
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
