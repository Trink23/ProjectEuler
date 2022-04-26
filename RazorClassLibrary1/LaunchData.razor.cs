using RazorClassLibrary1.Dtos;
using System.Net.Http.Json;

namespace RazorClassLibrary1
{
    public partial class LaunchData
    {
        private LaunchDto[] launches;

        protected override async Task OnInitializedAsync()
        {
            launches = await Http.GetFromJsonAsync<LaunchDto[]>("https://api.spacex.land/rest/launches/");
        }

    }
}
