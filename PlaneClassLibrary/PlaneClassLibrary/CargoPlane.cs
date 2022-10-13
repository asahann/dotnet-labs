using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PlaneClassLibrary
{
    public class CargoPlane : Plane
    {
        internal float Capacity;
        public CargoPlane(float Capacity, float CurrentSpeed, float Acceleration, string Race, float Wingspan, float MaxHigh, float MaxSpeed)
            : base(CurrentSpeed, Acceleration, "Cargo", Race, Wingspan, MaxHigh, MaxSpeed)
        {
            this.Capacity = Capacity;
        }
    }
}
