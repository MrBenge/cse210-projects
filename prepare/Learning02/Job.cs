using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startyear;
    public int _endyear;

    public void DisplayJobs()
    {
        Console.WriteLine($"{_company} {_jobTitle} {_startyear}-{_endyear}");
    }
}