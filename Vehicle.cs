namespace LearnInterfaces {
  class Vehicle {
    public string LicensePlate { get; protected set; }
    public double Speed { get; protected set; }
    public int Wheels { get; protected set; }
    public void Honk () { };
    public void SpeedUp () { };
    public void SlowDown () { };
  }
}