using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrintFinal.Models
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }

        [Required]

        public string Name { get; set; }

        public string Description { get; set; }

        public TimeSpan Duration { get; set; }

        public Movies()
        {

        }


    }

}
