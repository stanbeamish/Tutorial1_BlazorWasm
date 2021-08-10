using MyApp.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Client.Services
{
    public class VehicleService : IVehicleService
    {
        private List<Vehicle> _vehicles { get; set; }

        public VehicleService()
        {
            SeedFakeData();
        }

        public async Task<Vehicle> GetVehicleByIdAsync(int Id)
        {
            return await Task.FromResult(_vehicles.Find(v => v.Id == Id));
        }

        public async Task<List<Vehicle>> GetVehicles()
        {
            return await Task.FromResult(_vehicles);
        }

        private void SeedFakeData()
        {
            _vehicles = new List<Vehicle>
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
}
