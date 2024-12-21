using System;

class Activity
{
    protected DateTime _date;
    protected double _duration;

    public Activity(DateTime date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    // Virtual methods with default implementation
    public virtual double GetDistance()
    {
        return 0.0; 
    }

    public virtual double GetSpeed()
    {
        return 0.0; 
    }

    public virtual double GetPace()
    {
        return 0.0; 
    }

    // Summary method that can be used by all derived classes
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_duration} min) - " +
               $"Distance {GetDistance()} {GetDistanceUnit()}, Speed {GetSpeed()} {GetSpeedUnit()}, " +
               $"Pace: {GetPace()} {GetPaceUnit()}";
    }

    // Methods for unit selection 
    protected string GetDistanceUnit() => "miles"; 
    protected string GetSpeedUnit() => "mph"; 
    protected string GetPaceUnit() => "min per mile"; 
}
