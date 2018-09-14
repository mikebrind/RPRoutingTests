using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPRoutingTests.Services
{
    public interface ILocalizationService
    {
        List<LocalRoute> LocalRoutes();
    }
    public class LocalizationService : ILocalizationService
    {
        public List<LocalRoute> LocalRoutes()
        {
            var routes = new List<LocalRoute>
            {
                new LocalRoute{Page = "/Pages/Contact.cshtml", Versions = new List<string>{"kontakt", "contacto", "contatto", "kontakta" } }
            };
            return routes;
        }
    }

    public class LocalRoute
    {
        public string Page { get; set; }
        public List<string> Versions { get; set; }
    }
}
