using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeFinder.Core.Services;

namespace CoffeeFinder.WP8.Services
{
    public class WP8LocationService : ILocationService
    {
        public async Task<GeoCoords> GetLocationAsync()
        {
            var geolocator = new Windows.Devices.Geolocation.Geolocator();
            var geoposition = await geolocator.GetGeopositionAsync();

            var coords = new GeoCoords
            {
                Latitude = geoposition.Coordinate.Latitude,
                Longitude = geoposition.Coordinate.Longitude
            };

            return coords;
        }
    }
}
