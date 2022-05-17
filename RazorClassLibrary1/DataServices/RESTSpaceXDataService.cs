using RazorClassLibrary1.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary1.DataServices
{
    public class RESTSpaceXDataService : ISpaceXDataService
    {
        private readonly HttpClient _httpClient;

        public RESTSpaceXDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<LaunchDto[]> GetAllLaunches()
        {
           return await _httpClient.GetFromJsonAsync<LaunchDto[]>("/rest/launches/");

        }
    }
}
