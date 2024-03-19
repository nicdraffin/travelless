using System;
using System.Collections.Generic;
using System.IO;

namespace travelless.Components.Data
{
    public class FlightManager
    {
        private string csvFilePath = @"C:\Users\nicdr\OneDrive - Southern Alberta Institute of Technology\SAIT Year 1-2\OOP2\Unit 1\travelless\Resources\CSV_files\flights.csv";

        public List<string> Search(string to, string from, string day)
        {
            List<string> flightsList = new List<string>();


            string[] lines = File.ReadAllLines(csvFilePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length >= 7 && parts[2] == to && parts[3] == from && parts[4] == day)
                {
                    string flightCode = parts[0];
                    string airlineName = parts[1];
                    string fromAirport = parts[2];
                    string toAirport = parts[3];
                    string dayOfWeek = parts[4];
                    string departureTime = parts[5];
                    int passengerSeatsAvailable = int.Parse(parts[6]);
                    double costMoney = Convert.ToDouble(parts[7]);

                    string matchedData = $"{flightCode}, {airlineName}, {fromAirport}, {toAirport}, {dayOfWeek}, {departureTime}, {passengerSeatsAvailable}, {costMoney}";

                    flightsList.Add(matchedData);
                    break;
                }
            }

            return flightsList;
        }
    }
}
