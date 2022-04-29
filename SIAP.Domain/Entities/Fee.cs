using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIAP.Domain.Entities
{
    [Table("Fees", Schema = "dbo")]   
    public class Fee
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("FeeId")]
        public int Id { get; set; }
        public int PaymentId { get; set; }
        public float Amount { get; set; }
        public DateTime date { get; set; }

    }
}