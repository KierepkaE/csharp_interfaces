namespace LearnInterfaces {
  class Vehicle {
    public Vehicle (double speed) {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate ();
    }
    public string LicensePlate { get; protected set; }
    public double Speed { get; protected set; }
    public int Wheels { get; protected set; }
    public void Honk () { };
    public virtual void SpeedUp () { };
    public virtual void SlowDown () { };
  }
}