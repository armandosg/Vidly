using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter movie's name.")]
        public String Name { get; set; }
        
        [Required(ErrorMessage = "Please enter the release date.")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Please enter the number in stock.")]
        public int Stock { get; set; }

        public Genre Genre { get; set; }
        
        [Display(Name="Genre")]
        [Required(ErrorMessage = "Please enter the movie's genre.")]
        [Range(1, 20, ErrorMessage = "Please enter a number between 1 and 20")]
        public short GenreId { get; set; }
    }
}