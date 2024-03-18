using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace travelless.Components.Data
{
    class ReservationManager
    {
        private List<Reservation> reservations = new List<Reservation>();
        

        public Reservation MakeReservation(Flights FlightNumber, string AirlineName, string Citizenship)
        {
            
            Reservation reservation = new Reservation
            {
                FlightCode = Flights.FlightNumber,
                NameAirline = AirlineName,
                TravellerName = ,
                Citizenship = Citizenship,
                FlightStatus = true
            };

            reservations.Add(reservation);
            return reservation;
        }

        // Method to find reservations
        public List<Reservation> FindReservations(string reservationCode, string airline, string travelerName)
        {
            
            return reservations.Where(r => r.ReservationCode == reservationCode ||
                                            r.FlightCode.StartsWith(airline) ||
                                            r.TravellerName.Contains(travelerName)).ToList();
        }

        // Method to update reservation
        public void UpdateReservation(Reservation reservation, string name, string citizenship, bool isActive)
        {
            if (reservation == null || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(citizenship))
                throw new ArgumentException("Invalid input");

            reservation.TravellerName = name;
            reservation.Citizenship = citizenship;
            reservation.FlightStatus = isActive;
        }

        // Method to persist reservations to a file
        public void PersistReservations()
        {
            // Implement your logic to save reservations to a file
        }
    }

    // Example usage of the classes
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize your GUI here
            // Implement event handlers to interact with the backend logic

            // Example usage of backend logic
            

            try
            {
                Reservation reservation = ReservationManager.MakeReservation(Flights, "John Doe", "USA");
                Console.WriteLine("Reservation made: " + reservation);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error making reservation: " + ex.Message);
            }

            // Other operations like finding reservations, updating reservations can be performed similarly
        }
    }


}
