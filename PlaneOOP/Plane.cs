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

        public Plane(string destinationName, uint flightNumber, string departureTime)
        {
            this.destinationName = destinationName;
            if (flightNumber < 100000 || flightNumber > 999999)
            {
                throw new ArgumentException("Номер рейса должен быть шестизначным");
            }
            this.flightNumber = flightNumber;
            DateTime date = StringToDate(departureTime);
            this.departureTime = date;
        }

        public static bool operator >(Plane one, Plane two)
        {
            return (one.DepartureTime < two.DepartureTime) ? true : false;
        }

        public static bool operator <(Plane one, Plane two)
        {
            return (one.DepartureTime < two.DepartureTime) ? true : false;
        }

        private DateTime StringToDate(string StringDate)
        {
            DateTime date;
            bool IsParsed = DateTime.TryParse(StringDate, out date);
            return date;
        }
        public override string ToString()
        {
            string obj = "";
            obj += $"Пункт назначения: {destinationName}\nНомер рейса: {flightNumber}\nВремя отправления: {departureTime}\n";
            return obj;
        }
    }
}
