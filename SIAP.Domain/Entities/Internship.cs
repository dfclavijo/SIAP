using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAP.Domain.Entities
{
    [Table("Internships", Schema = "dbo")]   
    public class Internship : BaseEntity
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("InternshipsId")]   
        public int Id { get; set; }
        public int type { get; set; }
        public int StudentId { get; set; }
        public int? ProfessorId { get; set; }
        public int AggrementId { get; set; }
        public string Dependency { get; set; }
        public int Status { get; set; } //Enum
        public string Modality { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime EndDate { get; set; }
        public string EntryTime { get; set; }
        public string ExitTime { get; set; }
        public int WeekHours { get; set; }
        public bool IsPaid { get; set; }
        public string GeneralGoal { get; set; }
        public string SpecificGoals { get; set; }
        public string Observations { get; set; }
        public Professor ProfessorNavigation { get; set; }
        public Student StudentNavigation { get; set; }
        public Agreement AgreementNavigation { get; set; }
        public Supervisor SupervisorNavigation { get; set; }

    }
}
