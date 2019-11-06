using System;

namespace LearnInterfaces {
  interface IVehicle {
    string LicensePlate { get; }
    double Speed { get; }
    int Wheels { get; }
    void Honk ();
  }
}