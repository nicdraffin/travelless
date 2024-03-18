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
        public string Flightnumber { get; set; }
        public string AirlineName { get; set; }
        public string FromOrigin { get; set; }
        public string ToOrigin { get; set; }
        public string DayWeek { get; set; }
        public string DeptartureTime { get; set; }
        public string SeatPassenger { get; set; }
        public string CostMoney { get; set; }

        public override string ToString()
        {
            return $"{Flightnumber} - {AirlineName} - {FromOrigin} to {ToOrigin} - {DayWeek} - {DeptartureTime} - {SeatPassenger} - ${CostMoney}";
        }

    }
}
