using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PlaneClassLibrary
{
    public class PassengerPlane : Plane
    {
        internal int Passengers;
        public PassengerPlane() { }
        public PassengerPlane(int Passengers, float CurrentSpeed, float Acceleration, string Race, float Wingspan, float MaxHigh, float MaxSpeed)
            : base(CurrentSpeed, Acceleration, "Passenger", Race, Wingspan, MaxHigh, MaxSpeed)
        {
            this.Passengers = Passengers;
        }
    }
}
