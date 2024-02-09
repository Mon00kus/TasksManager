using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using TasksManager.AuthUI.Data;

namespace TasksManager.AuthUI.Components.Account
{
    // Elimine el bloque "else if (EmailSender is IdentityNoOpEmailSender)" de RegisterConfirmation.razor despu�s de actualizar con una implementaci�n real.
    internal sealed class IdentityNoOpEmailSender : IEmailSender<ApplicationUser>
    {
        private readonly IEmailSender emailSender = new NoOpEmailSender();

        public Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink) =>
            emailSender.SendEmailAsync(email, "Confirme su email", $"Por favor confirme su cuenta por <a href='{confirmationLink}'>clicking aqui</a>.");

        public Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink) =>
            emailSender.SendEmailAsync(email, "Restablecer su contrase�a", $"Por favor restablezca su contrase�a <a href='{resetLink}'>clicking aqui</a>.");

        public Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode) =>
            emailSender.SendEmailAsync(email, "Restablecer su contrase�a", $"Por favor restablezca su contrase�a usando el siguiente c�digo: {resetCode}");
    }
}