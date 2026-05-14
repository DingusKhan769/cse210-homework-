using System;
using System.Collections.Generic;

public class Resume
{
    public string _fullName;

    public List<Job> _jobHistory = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Full Name: {_fullName}");
        Console.WriteLine("Job History:");

        foreach (Job job in _jobHistory)
        {
            job.Display();
        }
    }
}