using Microsoft.AspNetCore.Components;

namespace BlazorHomework1.Pages
{
    public partial class Homework
    {
        [Parameter]
        public string Header { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }
        private void GoToHome()
        {
            NavigationManager.NavigateTo("/");
        }
    }
}
