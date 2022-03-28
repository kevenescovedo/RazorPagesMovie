using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Título")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Genêro")]
        public string Genre { get; set; } = string.Empty;
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        //[StringLength(5)]
        [Required]
        [Display(Name = "Classificação")]
        public string Rating { get; set; } = string.Empty;
    }
}