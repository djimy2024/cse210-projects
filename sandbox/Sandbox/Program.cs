using System;

public class JobHistory
{
    // Properties to store job information
    public string JobTitle { get; set; }
    public string Company { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Responsibilities { get; set; }

    // Constructor to initialize the job history
    public JobHistory(string jobTitle, string company, DateTime startDate, DateTime endDate, string responsibilities)
    {
        JobTitle = jobTitle;
        Company = company;
        StartDate = startDate;
        EndDate = endDate;
        Responsibilities = responsibilities;
    }

    // Method to display job details (abstraction of job history display)
    public void DisplayJobDetails()
    {
        Console.WriteLine($"Job Title: {JobTitle}");
        Console.WriteLine($"Company: {Company}");
        Console.WriteLine($"Duration: {StartDate.ToShortDateString()} - {EndDate.ToShortDateString()}");
        Console.WriteLine($"Responsibilities: {Responsibilities}");
    }
}
