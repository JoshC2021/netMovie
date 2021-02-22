using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace netMovieMVC.Models
{
    public enum Genre
    {
        Drama,
        Action,
        Horror,
        Romance,
        Comedy
    }
    public class Movie
    {
        public int ID { get; set; } = 0;
        public string Title { get; set; }
        public Genre Category { get; set; }
        public DateTime Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }
    }
}
