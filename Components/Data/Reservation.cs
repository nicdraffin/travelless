
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using travelless.Components.Data;


namespace travelless.Components.Data
{
    class Reservation
    {
        
        public string ReservationCode { get; set; }
        public string FlightCode { get; set;}
        public string TravellerName { get; set; }
        public string Citizenship { get; set; }
        public bool FlightStatus { get; set; }

        public Reservation(string code, string name, string citizenship, Flights flight, bool statusFlight)
        {
            ReservationCode = Reservation.rndReservationCode();
            FlightCode = code;
            TravellerName = name;
            Citizenship = citizenship;
            FlightStatus = statusFlight;
        }

        private static string rndReservationCode()
        {
            Random random = new Random();
            return $"{(char)random.Next('A', 'Z' + 1)}{random.Next(0, 10)}{random.Next(0, 10)}{random.Next(0, 10)}{random.Next(0, 10)}";
        }
        public override string ToString()
        {
            return $"{ReservationCode} - {TravellerName} - {FlightCode} - Active: {FlightStatus}";
        }
    }
}
