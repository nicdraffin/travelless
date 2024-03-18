using Java.Lang.Annotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Google.Crypto.Tink.Signature;
using static Java.Util.Jar.Attributes;

namespace travelless.Components.Data
{
    class Reservation
    {
        public string ReservationCode { get; set; }
        public string FlightCode { get; set;}
        public string TravellerName { get; set; }
        public string Citizenship { get; set; }
        public bool FlightStatus { get; set; }

        public override string ToString()
        {
            return $"{ReservationCode} - {TravellerName} - {FlightCode} - Active: {FlightStatus}";
        }

    }
}
