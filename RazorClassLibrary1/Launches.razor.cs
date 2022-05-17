using Microsoft.AspNetCore.Components;
using RazorClassLibrary1.DataServices;
using RazorClassLibrary1.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary1
{
    public partial class Launches
    {
        [Inject]
        ISpaceXDataService SPaceXDataService { get; set; }
        private LaunchDto[] launches;

        protected override async Task OnInitializedAsync()
        {

        }

    }
}
