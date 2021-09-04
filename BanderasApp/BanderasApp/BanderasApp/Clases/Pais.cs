using System.Collections.Generic;

namespace BanderasApp.Clases
{
    public class Pais
    {
        public int GeonameId { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        public string Capital { get; set; }
        public string CurrencyCode { get; set; }
        public string ContinentName { get; set; }
        public int Population { get; set; }
    }

    public class GeoPais
    {
        public List<Pais> Geonames { get; set; }
    }
}
