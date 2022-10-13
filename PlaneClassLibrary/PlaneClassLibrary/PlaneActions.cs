using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PlaneClassLibrary
{
    public static class PlaneActions
    {
        public static void WriteCurrentSpeed(Plane plane)
        {
            Console.Write($"{plane.CurrentSpeed} km/h");
            Console.WriteLine();
        }
        public static void ChangeCurrentSpeed(Plane plane, float SpeedChange) 
        {
            if ((plane.CurrentSpeed += SpeedChange) < plane.MaxSpeed)
            {
                plane.CurrentSpeed += SpeedChange;
            }
            else
            {
                Console.WriteLine("Max speed!");
                plane.CurrentSpeed = plane.MaxSpeed;
            }
        }
        public static void WritePlaneType(Plane plane)
        {
            Console.Write(plane.Type);
            Console.WriteLine();
        }
        public static void WritePlaneRace(Plane plane)
        {
            Console.Write(plane.Race);
            Console.WriteLine();
        }
        public static void WritePlaneWingspan(Plane plane)
        {
            Console.Write($"{plane.Wingspan} m");
            Console.WriteLine();
        }
        public static void WritePlaneMaxSpeed(Plane plane)
        {
            Console.Write($"{plane.MaxSpeed} km/h");
            Console.WriteLine();
        }
        public static void WritePlaneMaxHigh(Plane plane)
        {
            Console.Write($"{plane.MaxHigh} m");
            Console.WriteLine();
        }
    }
}
