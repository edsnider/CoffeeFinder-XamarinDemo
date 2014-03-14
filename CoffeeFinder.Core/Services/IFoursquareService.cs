using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeFinder.Core.Services
{
    public interface IFoursquareService
    {
        Task<VenuesResponse> GetVenues(string query, GeoCoords coords);
    }
}
