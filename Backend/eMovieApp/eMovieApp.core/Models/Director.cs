using System.ComponentModel.DataAnnotations;

namespace eMovieApp.Core.Models
{
    public class Director
    {
        [Key]
        public int DirectorId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public char? Sex { get; set; }
    }
}
