using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cascading
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public int ContinentId { get; set; }
        public Continent Continent { get; set; }
    }
}