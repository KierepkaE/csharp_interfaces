namespace LearnInterfaces {
  class Vehicle {
    public Vehicle (double speed) {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate ();
    }
    public string LicensePlate { get; private set; }
    public double Speed { get; private set; }
    public int Wheels { get; protected set; }
    public void Honk () { };
    public void SpeedUp () { };
    public void SlowDown () { };
  }
}