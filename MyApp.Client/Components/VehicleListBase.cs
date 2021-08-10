using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Client.Components
{
    public class VehicleListBase : ComponentBase
    {
        protected List<Vehicle> Vehicles { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            InitVehicles();

        }

        private void InitVehicles()
        {
            Vehicles = new List<Vehicle>
            {
                new Vehicle
                {
                    Id = 1,
                    Name = "Red Vehicle",
                    BatteryLoad = 72.3
                },
                new Vehicle
                {
                    Id = 2,
                    Name = "Blue Vehicle",
                    BatteryLoad = 45.7
                },
                        new Vehicle
                {
                    Id = 3,
                    Name = "Green Vehicle",
                    BatteryLoad = 89.0
                }
            };
        }

    }

    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double BatteryLoad { get; set; }
    }

}
