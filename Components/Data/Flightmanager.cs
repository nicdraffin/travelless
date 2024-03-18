using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace travelless.Components.Data
{
    public class FlightManager
    {
        private string csvFilePath = @"C:\Travelless\Resources\CSV_files\flights.csv";
        private List<string> searchResults = new List<string>();


            public void populateFlight()
            {
                Flights flight;
                foreach (string line in File.ReadLines(csvFilePath))
                {
                    string[] parts = line.Split(',');


                    string flightCode = parts[0];
                    string airlineName = parts[1];
                    string fromAirport = parts[2];
                    string toAirport = parts[3];
                    string day = parts[4];
                    string deptartureTime = parts[5];
                    int passengerseatsavaliable = int.Parse(parts[6]);
                    double costMoney = Convert.ToDouble(parts[7]);


                    flight = new Flights(flightCode, airlineName, fromAirport, toAirport, day, deptartureTime, passengerseatsavaliable, costMoney);
                    searchResults.Add(flight);
                }
            }


        }

    }
}