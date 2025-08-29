using System.Net;

namespace SchoolManagementSystem.Models.People
{
    public abstract class Person
    {
        public int personId { get; set; }
        required public string FirstName { get; set; }
        required public string LastName { get; set; }
        required public DateTime DateOfBirth { get; set; }
        required public string Email { get; set; }

        required public string PhoneNo { get; set; }

        

    }

}
