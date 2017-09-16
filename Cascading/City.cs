﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cascading
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}