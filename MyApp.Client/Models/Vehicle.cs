using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Client.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int VehicleTypeId { get; set; }
        public double BatteryLoad { get; set; }
        public int CurrentLocationId { get; set; }
        public DateTime DateForMaintenance { get; set; }
        public bool IsLoaded { get; set; }

    }
}
