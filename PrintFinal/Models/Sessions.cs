using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrintFinal.Models
{
    public class Sessions
    {
        [Key]
        public int Id { get; set; }

        public Movies Movies { get; set; }

        public Rooms Rooms { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Session_Date { get; set; }
        public TimeSpan Begin { get; set; }

        [Display(Name = "Ticket Value")]
        public float Ticket_Values { get; set; }

        public string Movie_Type { get; set; }

        public string Audio_Type { get; set; }



        [ForeignKey("Rooms")]

        public int RoomsFK { get; set; }


        [ForeignKey("Movies")]

        public int MoviesFK { get; set; }

        public Sessions()
        {

        }
    }
}
