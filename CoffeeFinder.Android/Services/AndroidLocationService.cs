using System;
using System.Threading.Tasks;
using Android.Content;
using CoffeeFinder.Core.Services;
using Xamarin.Geolocation;

namespace CoffeeFinder.Android.Services
{
    public class AndroidLocationService : ILocationService
    {
        private Context _appContext;

        public AndroidLocationService(Context appContext)
        {
            this._appContext = appContext;
        }

        public async Task<GeoCoords> GetLocationAsync()
        {
            var locator = new Geolocator(this._appContext) { DesiredAccuracy = 30 };
            var position = await locator.GetPositionAsync(30000);

            var result = new GeoCoords
            {
                Latitude = position.Latitude,
                Longitude = position.Longitude
            };

            return result;
        }
    }
}