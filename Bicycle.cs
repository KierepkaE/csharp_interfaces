namespace LearnInterfaces {
  class Bicycle : Vehicle {

    public Bicycle (double peed) : base (speed) {
      Wheels = 2;
    }
    public override void SpeedUp () {
      Speed += 5;
      if (Speed > 15) {
        Speed = 15;
      }
    }

    public override void SlowDown () {
      Speed -= 5;
      if (Speed < 15) {
        Speed = 0;
      }
    }
    public override string Describe () {
      return $"This Bicycle is moving on {Wheels} wheels at {Speed} km/h.";
    }

  }
}