namespace SchoolManagementSystem.Models.Roles
{
    public class Role
    {
        required public int RoleId { get; set; }
        required public RoleName RoleName { get; set; }
    }
}

public enum RoleName
{
    Administrator,
    Student, 
    Teacher 
}

