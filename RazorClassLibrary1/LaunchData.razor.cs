using Microsoft.AspNetCore.Components;
using RazorClassLibrary1.Dtos;
using System.Net.Http.Json;

namespace RazorClassLibrary1
{
    public partial class LaunchData
    {
        private LaunchDto[] launches;
        [Inject]
        private HttpClient Http { get; set; }
        protected override async Task OnInitializedAsync()
        {

            launches = await Http.GetFromJsonAsync<LaunchDto[]>("https://api.spacex.land/rest/launches/");
        }

    }
}
