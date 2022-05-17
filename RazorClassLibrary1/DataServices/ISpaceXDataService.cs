using RazorClassLibrary1.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary1.DataServices
{
    public interface ISpaceXDataService
    {
        public Task<LaunchDto[]> GetAllLaunches();

    }
}
