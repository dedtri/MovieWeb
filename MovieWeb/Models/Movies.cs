using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieWeb.Models
{
    public class Movies
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public string? Director { get; set; }

        [Display(Name = "Release Year")]
        public int ReleaseYear { get; set; }
    }
}
