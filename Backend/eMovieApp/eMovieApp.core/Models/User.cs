using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eMovieApp.Core.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public int UserRoleId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }

        [ForeignKey("UserRoleId")]
        public UserRole? UserRole { get; set; }
    }
}
