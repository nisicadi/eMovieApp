using System.ComponentModel.DataAnnotations;

namespace eMovieApp.Core.Models
{
    public class UserRole
    {
        [Key]
        public int UserRoleId { get; set; }
        public string? RoleName { get; set; }
    }
}
