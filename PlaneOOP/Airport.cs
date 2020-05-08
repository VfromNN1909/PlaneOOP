using System;
using System.Collections.Generic;

namespace PlaneOOP
{
    class Airport
    {
        private SortedList<DateTime,Plane> airport;
        public Airport()
        {
            airport = new SortedList<DateTime, Plane>();
        }
        public void AddPlane(Plane plane)
        {
            if(plane != null)
            {
                airport.Add(plane.DepartureTime, plane);
            }          
        }
        public void AddPlanes(params Plane[] planes)
        {
            if(planes != null || planes.Length != 0)
            {
                foreach(Plane plane in planes)
                {
                    airport.Add(plane.DepartureTime, plane);
                }
            }
        }
        public void GetInfo(int index)
        {
            if(index < 0 || index > airport.Count - 1)
            {
                throw new IndexOutOfRangeException("Такого рейса не существует");
            }
            var planes = airport.Values;
            Console.WriteLine("Пункт назначения: " + planes[index].DestinationName);
            Console.WriteLine("Номер рейса: " + planes[index].FlightNumber);
            Console.WriteLine("Пункт назначения: " + planes[index].DepartureTime);
        }
        public void GetPlanesInOneHour(DateTime time)
        {
            DateTime PlusHour = new DateTime(time.Year, time.Month, time.Day,
                time.Hour + 1, time.Minute, time.Second, DateTimeKind.Local);
            Console.WriteLine("В течение часа вылетят следующие самолеты: ");
            foreach(DateTime PlaneTime in airport.Keys)
            {
                if(PlaneTime > time && PlaneTime < PlusHour)
                {                   
                    GetInfo(airport.IndexOfKey(PlaneTime));
                }
            }
        }
        public void GetPlanesByDestinationName(string DestinationName)
        {
            Console.WriteLine($"В пункт назначения {DestinationName} летят следующие самолеты: ");
            foreach(Plane plane in airport.Values)
            {
                if (plane.DestinationName.Equals(DestinationName))
                {
                    GetInfo(airport.IndexOfValue(plane));
                }
            }
        }      
    }
}
