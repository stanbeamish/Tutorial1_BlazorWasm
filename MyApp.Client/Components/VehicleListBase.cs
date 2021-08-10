using Microsoft.AspNetCore.Components;
using MyApp.Client.Models;
using MyApp.Client.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyApp.Client.Components
{
    public class VehicleListBase : ComponentBase
    {
        [Inject]
        private IVehicleService VehicleService { get; set; }

        protected List<Vehicle> Vehicles { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await InitVehiclesAsync();
        }

        private async Task InitVehiclesAsync()
        {
            Vehicles = await VehicleService.GetVehicles();
        }
    }
}
