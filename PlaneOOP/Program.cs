using System;

namespace PlaneOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Airport airport = new Airport();
            Plane plane = new Plane("Москва", 999999, new DateTime(2020, 3, 15, 13, 30, 0, 0));
            Plane plane1 = new Plane("Киев", 999998, "15.03.2020 12:45:00");
            Plane plane2 = new Plane("Минск", 999997, "18.02.2020 09:15:00");
            Plane plane3 = new Plane("Париж", 999996, new DateTime(2020, 2, 17, 22, 0, 0, 0));
            airport.AddPlanes(plane, plane1, plane2, plane3);
            airport.GetAllPlanes();

        }
    }
}
