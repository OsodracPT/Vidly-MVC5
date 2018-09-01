using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Vidly.Models
{
    public class Movie
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the movie's name.")]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }

        [Display(Name = "Quantity in stock")]
        [Range(1, 20)]
        public byte QuantityInStock { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        public byte NumberAvailable { get; set; }

    }
}