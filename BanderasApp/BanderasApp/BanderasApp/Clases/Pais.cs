using System.Collections.Generic;

namespace BanderasApp.Clases
{
    public class Pais
    {
        public int GeonameId { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
    }

    public class GeoPais
    {
        public List<Pais> Geonames { get; set; }
    }
}
