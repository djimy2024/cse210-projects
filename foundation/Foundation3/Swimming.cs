class Swimming : Activity
{
    protected int _laps;

    public Swimming(DateTime date, double duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Distance in meters, each lap is 50 meters
        return _laps * 50 / 1000.0; // Convert meters to kilometers
    }

    public override double GetSpeed()
    {
        // Speed = Distance / Time (in hours)
        return GetDistance() / (_duration / 60);
    }

    public override double GetPace()
    {
        // Pace = Time / Distance (in kilometers)
        return _duration / GetDistance();
    }

    // Override units for swimming
    protected new string GetDistanceUnit() => "km";
    protected new string GetSpeedUnit() => "kph";
    protected new string GetPaceUnit() => "min per km";

}