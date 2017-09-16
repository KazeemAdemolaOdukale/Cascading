using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Cascading
{
    public class CascadingRepository : DropCreateDatabaseIfModelChanges<CascadingDbContext>
    {
        protected override void Seed(CascadingDbContext context)
        {
            List<Continent> continents = new List<Continent>()
            {
                new Continent { Name="Europe" }, new Continent { Name="South America" }, new Continent { Name="Africa" }
            };
            List<Country> countries = new List<Country>()
            {
                new Country { Name="Sweden", CountryId=1 }, new Country { Name="United Kingdom", CountryId=1 }, new Country { Name="Italy", CountryId=1 },
                new Country { Name="Brazil", CountryId=2 }, new Country { Name="Argentina", CountryId=2 }, new Country { Name="Colombia", CountryId=2 },
                new Country { Name="Nigeria", CountryId=3 }, new Country { Name="Egypt", CountryId=3 }, new Country { Name="South Africa", CountryId=3 }
            };
            List<City> cities = new List<City>()
            {
                new City { Name="Uddevalla", CountryId=1 }, new City { Name="Gothenburg", CountryId=1 }, new City { Name="Stockholm", CountryId=1 },
                new City { Name="London", CountryId=2 }, new City { Name="Manchester", CountryId=2 }, new City { Name="Newcastle", CountryId=2 },
                new City { Name="Rome", CountryId=3 }, new City { Name="Milan", CountryId=3 }, new City { Name="Turin", CountryId=3 },
                new City { Name="Sao Paolo", CountryId=4 }, new City { Name="Brazilia", CountryId=4 }, new City { Name="Rio de Jeneiro", CountryId=4 },
                new City { Name="Buenos Aires", CountryId=5 }, new City { Name="Catamanca", CountryId=5 }, new City { Name="Cordoba", CountryId=5 },
                new City { Name="Bogota", CountryId=6 }, new City { Name="Cali", CountryId=6 }, new City { Name="Medellin", CountryId=6 },
                new City { Name="Lagos", CountryId=7 }, new City { Name="Port Harcourt", CountryId=7 }, new City { Name="Kano", CountryId=7 },
                new City { Name="Cairo", CountryId=8 }, new City { Name="Alexandria", CountryId=8 }, new City { Name="Gizeh", CountryId=8 },
                new City { Name="Johanesburg", CountryId=9 }, new City { Name="Cape Town", CountryId=9 }, new City { Name="Durban", CountryId=9 },
            };
            context.Cities.AddRange(cities);
            context.Countries.AddRange(countries);
            context.Continents.AddRange(continents);
            base.Seed(context);
        }
    }
}