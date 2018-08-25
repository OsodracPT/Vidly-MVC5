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
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }

        [Display(Name = "Quantity in stock")]
        public byte QuantityInStock { get; set; }

        public Genres Genres { get; set; }

        [Display(Name = "Genre")]
        public byte GenresId { get; set; }


    }
}