using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIAP.Domain.Entities
{
    [Table("Company", Schema = "dbo")]
    public class Deliverables
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("DeliverableId")]   
        public int Id { get; set; }
        public string Desc { get; set; }
        public DateTime Date { get; set; }
    }
}