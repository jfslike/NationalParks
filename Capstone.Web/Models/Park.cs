﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models
{
    public class Park
    {
        public string ParkCode { get; set; }

        public string ParkName { get; set; }

        public string State { get; set; }

        public int Acreage { get; set; }

        public int ElevationInFeet { get; set; }

        public double MilesOfTrail { get; set; }

        public int NumberOfCampsites { get; set; }

        public string Climate { get; set; }

        public int YearFounded { get; set; }

        public int AnnualVisitorCount { get; set; }

        public string InspirationalQuote { get; set; }

        public string InspirationalQuoteSource { get; set; }

        public string ParkDescription { get; set; }

        public decimal EntryFee { get; set; }

        public int NumberOfAnimalSpecies { get; set; }

        public string ParkURL
        {
            get
            {
                return ParkName.Replace(" ", "%20");
            }
        }

        public List<WeatherForecast> Forecasts { get; set; }

    }
}
