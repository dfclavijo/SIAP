using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIAP.Domain.Entities
{
    [Table("Supervisor", Schema = "dbo")]
    public class Supervisor
    {
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("SupervisorId")]   
    public int Id { get; set; }
    public string Name { get; set; }
    public string CellPhone { get; set; }
    public string Email { get; set; }       
    public string Position { get; set; }
    public ICollection<Internship> Internships { get; set; }
    }
}