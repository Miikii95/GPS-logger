using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapForLogger._03
{
    internal class TrackPoint
    {
        public float _longitude { get; set; }
        public float _latitude { get; set; }
        public DateTime _time { get; set; }
        public float _elevation { get; set; }
        
        public TrackPoint(float longitude, float latitude) 
        {
            _longitude = longitude;
            _latitude = latitude;
        }

        public TrackPoint(float longitude, float latitude, DateTime time)
        {
            _longitude = longitude;
            _latitude = latitude;
        }
    }
}
