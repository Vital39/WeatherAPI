using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Interfaces
{
    public class LocationServiceExeption : Exception
    {

    }

    public interface IGetLocationServices
    {
        Task<Location> GetCurrentLocation();
    }
}
