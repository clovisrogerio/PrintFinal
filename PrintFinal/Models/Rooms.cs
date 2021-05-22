using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrintFinal.Models
{
    public class Rooms
    {
        [Key]
        public int Id { get; set; }

        [Required]

        public string Name { get; set; }

        public int Num_Seat { get; set; }

        public Rooms()
        {

        }

    }
}
