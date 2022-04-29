using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAP.Domain.Entities
{
    [Table("Documents", Schema = "dbo")]
    public class Documents
    {   [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("DocumentId")]
        public int Id { get; set; }
        public string CDP { get; set; }
        public string ARL { get; set; }
    }
}
