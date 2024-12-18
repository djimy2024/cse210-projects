using System;

abstract class Activity
{
    protected DateTime _date;
    protected double _duration;

    public Activity(DateTime date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    // Abstract methods to be overridden in derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

     // Summary method that can be used by all derived classes
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_duration} min) - " +
        $"Distance {GetDistance()} {GetDistanceUnit()}, Speed {GetSpeed()} {GetSpeedUnit()}, " +
        $"Pace: {GetPace()} {GetPaceUnit()}";
    }

    //methods for unit selection (assumes miles and miles per hour)
    protected string GetDistanceUnit() => "miles"; 
    protected string GetSpeedUnit() => "mph"; 
    protected string GetPaceUnit() => "min per mile"; 
}