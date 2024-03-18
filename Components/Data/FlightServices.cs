using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using travelless.Components.Data;

public class FlightService
{
    private List<FlightModel> flights;

    public FlightService()
    {
        flights = new List<FlightModel>();
        LoadFlightsFromCSV();
    }

    private void LoadFlightsFromCSV()
    {
        using (TextFieldParser parser = new TextFieldParser("flights.csv"))
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while (!parser.EndOfData)
            {
                string[] fields = parser.ReadFields();
                if (fields != null && fields.Length >= 4)
                {
                    flights.Add(new FlightModel
                    {
                        FlightNumber = fields[0],
                        Origin = fields[1],
                        Destination = fields[2],
                        DepartureTime = DateTime.ParseExact(fields[3], "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)
                    });
                }
            }
        }
    }

    public FlightModel FindFlight(string flightNumber)
    {
        return flights.FirstOrDefault(f => f.FlightNumber.Equals(flightNumber, StringComparison.OrdinalIgnoreCase));
    }
}
