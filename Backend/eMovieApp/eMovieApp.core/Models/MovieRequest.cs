using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eMovieApp.Core.Models
{
    public class MovieRequest
    {
        [Key]
        public int MovieId { get; set; }
        public string? Title { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int DirectorId { get; set; }
        public int LanguageId { get; set; }
        //public int ProducerId { get; set; }
        //public int GenreId { get; set; }
        //public int StudioId { get; set; }
        //public int MovieRatingId { get; set; }
        //public int WriterId { get; set; }
        //public int ScreenWriterId { get; set; }

        [ForeignKey("DirectorId")]
        public Director? Director { get; set; }
        [ForeignKey("LanguageId")]
        public Director? Language { get; set; }
    }
}
