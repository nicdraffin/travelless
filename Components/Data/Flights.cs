using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelless.Components.Data
{
    public class Flights
    {
        public Flights(string flightCode, string airlineName, string fromAirport, string toAirport, string day, string deptartureTime, int passengerseatsavaliable, double costMoney)
        {
            FlightCode = flightCode;
            AirlineName = airlineName;
            FromAirport = fromAirport;
            ToAirport = toAirport;
            Day = day;
            DeptartureTime = deptartureTime;
            Passengerseatsavaliable = passengerseatsavaliable;
            CostMoney1 = costMoney;
        }

        public string Flightnumber { get; set; }
        public string AirlineName { get; set; }
        public string FromOrigin { get; set; }
        public string ToOrigin { get; set; }
        public string DayWeek { get; set; }
        public string DeptartureTime { get; set; }
        public string SeatPassenger { get; set; }
        public string CostMoney { get; set; }
        public string FlightCode { get; }
        public string FromAirport { get; }
        public string ToAirport { get; }
        public string Day { get; }
        public int Passengerseatsavaliable { get; }
        public double CostMoney1 { get; }

        public override string ToString()
        {
            return $"{Flightnumber} - {AirlineName} - {FromOrigin} to {ToOrigin} - {DayWeek} - {DeptartureTime} - {SeatPassenger} - ${CostMoney}";
        }

    }
}
