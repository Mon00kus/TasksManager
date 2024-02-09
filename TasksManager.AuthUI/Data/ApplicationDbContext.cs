using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TasksManager.AuthUI.Data
{
    public class ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options) : 
        IdentityDbContext<ApplicationUser>(options)
    {
    }
}
