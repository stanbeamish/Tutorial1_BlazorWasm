using MyApp.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyApp.Client.Services
{
    public interface IVehicleService
    {
        Task<List<Vehicle>> GetVehicles();
        Task<Vehicle> GetVehicleByIdAsync(int Id);
    }
}
