using Microsoft.AspNetCore.Components;

namespace BlazorHomework1.Pages
{
    public partial class Home
    {
        [Inject]
        NavigationManager NavigationManager { get; set; }
        public void GoToHomework()
        {
            NavigationManager.NavigateTo("/homework/parameter");
        }
    }
}
