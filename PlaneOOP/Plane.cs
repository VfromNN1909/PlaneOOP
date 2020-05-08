using System;
using System.Collections.Generic;
using System.Text;

namespace PlaneOOP
{
    class Plane
    {
        private string destinationName;
        private uint flightNumber;
        private DateTime departureTime;

        public string DestinationName
        {
            get => destinationName;
            set => destinationName = value;
        }
        public uint FlightNumber
        {
            get => flightNumber;
            set => flightNumber = value;
        }
        public DateTime DepartureTime
        {
            get => departureTime;
            set => departureTime = value;
        }

        public Plane(string destinationName, uint flightNumber, DateTime departureTime)
        {
            this.destinationName = destinationName;
            if(flightNumber < 100000 || flightNumber > 999999)
            {
                throw new ArgumentException("Номер рейса должен быть шестизначным");
            }
            this.flightNumber = flightNumber;
            this.departureTime = departureTime;
        }

        public static bool operator >(Plane one, Plane two)
        {
            return (one.DepartureTime < two.DepartureTime) ? true : false;
        }

        public static bool operator <(Plane one, Plane two)
        {
            return (one.DepartureTime < two.DepartureTime) ? true : false;
        }

    }
}
