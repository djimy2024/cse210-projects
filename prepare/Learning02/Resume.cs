using System;
using System.Collections.Generic;

public class Resume
{

    public string _name;
    // initialize the list to a new list.
    public List<Job> _jobs = new List<Job>();
    public void Display()
    {
        Console.WriteLine($"name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach(Job job in _jobs)
        {
            job.Display();
        }
    }
}