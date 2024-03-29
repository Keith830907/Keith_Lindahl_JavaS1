﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS409_Team1.GoogleMaps
{
    public class Step
    {
        public Distance distance { get; set; }
        public Duration duration { get; set; }
        public MapPoint end_location { get; set; }
        public string html_instructions { get; set; }
        public Polyline polyline { get; set; }
        public MapPoint start_location { get; set; }
        public string travel_mode { get; set; }
        public string maneuver { get; set; }
    }
}
