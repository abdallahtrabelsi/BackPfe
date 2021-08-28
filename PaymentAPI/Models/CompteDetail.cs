using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class CompteDetail
    {
        [Key]
        public int CompteDetailId { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string CO { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Lib { get; set; }

        [Column(TypeName = "nvarchar(8)")]
        public string DB { get; set; }

        [Column(TypeName = "nvarchar(8)")]
        public string CR { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Compte { get; set; }

        [Column(TypeName = "float")]
        public string Ouvert_db { get; set; }

        [Column(TypeName = "float")]
        public string Ouvert_cr { get; set; }
    }
}
