using Microsoft.AspNetCore.Identity.UI.Services;

// blank implementation for development environment
// real smtp implementation would go here for production
namespace SchoolManagementSystem.Services
{
    public class DevEmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // For development: log to console
            Console.WriteLine($"[Email to {email}] {subject}\n{htmlMessage}");
            return Task.CompletedTask;
        }
    }
}