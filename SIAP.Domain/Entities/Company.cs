using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAP.Domain.Entities
{
    [Table("Company", Schema = "dbo")]
    public class Company
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CompanyId")]
        public int Id { get; set; }
        public string Nit { get; set; }
        public string Name { get; set; }
        public string LegalNature { get; set;}
        public ICollection<Agreement> Aggreements { get; set; }


    }
}
