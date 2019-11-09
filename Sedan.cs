using System;

namespace LearnInterfaces {

  class Sedan : Vehicle, IVehicle {
    public Sedan (double speed) : base (speed) {
      Wheels = 4;
    }
  }
}