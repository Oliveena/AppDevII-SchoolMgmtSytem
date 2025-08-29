using SchoolManagementSystem.Models.Users;

namespace SchoolManagementSystem.Models.People
{
    public class Administrator
    {
        public int AdministratorId { get; set; }

        public required string AdministrationStaffNumber { get; set; }

        // Link to Identity user
        public required string ApplicationUserId { get; set; }
        public required ApplicationUser ApplicationUser { get; set; }

        // Optional: Add more admin-specific properties or permissions later
    }
}
