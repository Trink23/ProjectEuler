using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RazorClassLibrary1.Dtos
{
    internal class LaunchDto
    {
        [JsonPropertyName("Id")]        
        public string Id { get; set; }
        [JsonPropertyName("is_tentative")]
        public bool IsTentative { get; set; }
        [JsonPropertyName("launch_date_local")]
        public DateTimeOffset LaunchDateLocal { get; set; }
        [JsonPropertyName("mission_name")]
        public string MissionName { get; set; }
    }
}
