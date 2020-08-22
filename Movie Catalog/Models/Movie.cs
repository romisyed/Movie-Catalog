using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Movie Title")]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Year of Release")]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Production studio")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 10)]
        [Display(Name = "Review Score Out of 10")]
        [Column(TypeName = "decimal(18,2)")]
        public int Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Display(Name = "Notable Actors (Initials)")]
        [StringLength(40)]
        [Required]
        public string Rating { get; set; }
    }
}
