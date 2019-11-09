using System;

namespace LearnInterfaces {
  class Truck : Vehicle, IVehicle {

    public double Weight { get; }

    public Truck (double speed, double weight) {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate ();
      Weight = weight;

      if (weight < 400) {
        Wheels = 8;
      } else {
        Wheels = 12;
      }
    }
    public override string Describe () {
      return $"This Truck is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
    }
  }
}