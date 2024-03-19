using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using travelless.Components.Data;
using travelless.Components.Pages;


namespace travelless.Components.Data
{
    public class ReservationManager
    {
        
       
        public class PassengerInfo
        {
            public string FlightCode { get; set; }
            public string Airline { get; set; }
            public string Day { get; set; }
            public string Time { get; set; }
            public string Cost { get; set; }
            public string Name { get; set; }
            public string Citizenship { get; set; }
        }


       


    }
}
