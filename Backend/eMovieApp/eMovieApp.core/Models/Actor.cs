using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eMovieApp.Core.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public char? Sex { get; set; }
    }
}
