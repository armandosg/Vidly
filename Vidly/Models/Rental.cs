using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Rental
    {
        public int Id { get; set; }
        [Required]
        public Customer Customer { get; set; }
        [Required]
        public Movie Movie { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateRented { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? DateReturned { get; set; }
    }
}