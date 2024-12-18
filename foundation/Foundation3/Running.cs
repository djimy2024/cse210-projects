class Running : Activity
{
   private double _distance;

   public Running(DateTime date, double duration, double distance) : base(date, duration)
   {
    _distance = distance;
   }

    public override double GetDistance() => _distance;

      public override double GetSpeed()
    {
        // Speed = Distance / Time (in hours)
        return _distance / (_duration / 60);
    }

     public override double GetPace()
    {
        // Pace = Time / Distance
        return _duration / _distance;
    }
}