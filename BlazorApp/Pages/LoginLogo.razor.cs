using BlazorApp.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace BlazorApp.Pages
{
    
    public partial class LoginLogo
    {
        MudForm form;
        string PasswordInputIcon = Icons.Material.Filled.VisibilityOff;
        bool isShowPasswor;
        string Messages;
        InputType PasswordInput = InputType.Password;

        [Inject] NavigationManager NavigationManager { get; set; }

        public Credential credential = new();

        void LogIn() => NavigationManager.NavigateTo("/dashboard");

        void ButtonTestclick()
        {
            if (isShowPasswor)
            {
                PasswordInputIcon = Icons.Material.Filled.VisibilityOff;
                PasswordInput = InputType.Password;
            }
            else
            {
                isShowPasswor = true;
                PasswordInputIcon = Icons.Material.Filled.Visibility;
                PasswordInput = InputType.Text;
            }
            isShowPasswor = !isShowPasswor;
        }

        private IEnumerable<string> ValidateUser(string usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario))
            {
                yield return "Your email is required!";
                yield break;
            }
        }

        private IEnumerable<string> ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                yield return "Your password is required!";
                yield break;
            }
        }
    }
}
