using System;

public class Job
{
    public string Company;
    public string JobTitle;
    public int StartYear;
    public int EndYear;

    public void Display()
    {
        Console.WriteLine($"{JobTitle} ({Company})");
        Console.WriteLine($"{StartYear}-{EndYear}");
    }
    public Job (string Company, string JobTitle, int StartYear, int EndYear)
    {
        this.Company = Company;
        this.JobTitle = JobTitle;
        this.StartYear = StartYear;
        this.EndYear = EndYear;
    }
}