using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PlaneClassLibrary
{
    public class Plane
    {
        internal float CurrentSpeed, Acceleration, Wingspan, MaxHigh, MaxSpeed;
        internal string Type, Race;

        public Plane() { }
        public Plane(float CurrentSpeed, float Acceleration, string Type, string Race, float Wingspan, float MaxHigh, float MaxSpeed)
        {
            this.CurrentSpeed = CurrentSpeed;
            this.Acceleration = Acceleration;
            this.Type = Type;
            this.Race = Race;
            this.Wingspan = Wingspan;
            this.MaxHigh = MaxHigh;
            this.MaxSpeed = MaxSpeed;
        }

        
    }
}
