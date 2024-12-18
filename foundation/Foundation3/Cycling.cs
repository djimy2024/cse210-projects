class Cycling : Activity
{
    protected double _speed;

    public Cycling(DateTime date, double duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

      public override double GetDistance()
    {
        // Distance = Speed * Time (in hours)
        return _speed * (_duration / 60);
    }

    public override double GetSpeed() => _speed;

    public override double GetPace()
    {
        // Pace = 60 / Speed (in miles per hour)
        return 60 / _speed;
    }
}