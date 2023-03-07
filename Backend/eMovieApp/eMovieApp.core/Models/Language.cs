using System.ComponentModel.DataAnnotations;

namespace eMovieApp.Core.Models
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }
        public string? LanguageName { get; set; }
    }
}
