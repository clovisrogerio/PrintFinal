using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintFinal.Models
{
    public class Language
    {
        [Key]
        public int Id { get; set; }

        [Required]

        public Movies Movies { get; set; }
    }
}
