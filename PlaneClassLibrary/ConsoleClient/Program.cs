using PlaneClassLibrary;
//1)Create some planes
Plane plane1 = new PassengerPlane(160, 880, 10, "Paris-Praga", 26, 2000, 1200);
Plane plane2 = new PassengerPlane(150, 750, 20, "Berlin-London", 26, 2000, 1200);
Plane plane3 = new CargoPlane(1250000, 750, 10, "Praga-Berlin", 26, 2500, 900);
Plane plane4 = new CargoPlane(130000, 700, 5, "London-Paris", 26, 2500, 900);
//2)Get Current speed
Console.Write("Current speed of plane1:");
PlaneActions.WriteCurrentSpeed(plane1);
//3)Change speed
PlaneActions.ChangeCurrentSpeed(plane1, 500);
Console.Write("New current speed of plane1:");
PlaneActions.WriteCurrentSpeed(plane1);
//4)Get plane type
Console.Write("Type of plane1:");
PlaneActions.WritePlaneType(plane1);
//5)Get current race
Console.Write("Race of plane1:");
PlaneActions.WritePlaneRace(plane1);
//6)Get wingspan
Console.Write("Wingspan of plane1:");
PlaneActions.WritePlaneWingspan(plane1);
//7)Get max speed
Console.Write("Max speed of plane 1:");
PlaneActions.WritePlaneMaxSpeed(plane1);
//8)Get max high
Console.Write("Max high of plane1:");
PlaneActions.WritePlaneMaxHigh(plane1);

