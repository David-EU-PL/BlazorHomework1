using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorHomework1.Pages
{
    public partial class Homework
    {
        [Parameter]
        public string Header { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        [Inject]
        public IJSRuntime JSRuntime { get; set; }
        private void GoToHome()
        {
            NavigationManager.NavigateTo("/");
        }

        private async Task ChangeBackground()
        {
            await JSRuntime.InvokeVoidAsync("changeBackgroundColor");
        }
    }
}
