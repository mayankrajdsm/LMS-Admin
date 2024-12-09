using LMS.Infrastructures.Models;

namespace LMS.Admin.Models
{
    public class UserModel
    {
        public Guid? Id { get; set; }

        public string? UserId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string? PhoneNumber { get; set; }

        public DateOnly? Dob { get; set; }

        public string? Gender { get; set; }

        public string? Address { get; set; }

        public DateTime? LastLogin { get; set; }

        public string? Status { get; set; }

        public Guid? Role { get; set; }

        public virtual LoginType? RoleNavigation { get; set; }
    }
}
