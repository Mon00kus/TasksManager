using Microsoft.AspNetCore.Identity;
using TasksManager.AuthUI.Data;

namespace TasksManager.AuthUI.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<ApplicationUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<ApplicationUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager
                    .RedirectToWithStatus("Account/InvalidUser", $"Error: No se puede llamar usuario con ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
