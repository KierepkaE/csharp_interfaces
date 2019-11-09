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
  }
}