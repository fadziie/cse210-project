using System;

public class Resume
{
    public string _name;

    public List<Job>_jobs = new List<Job>();

    public void DisplayResumeDetails(){}
    public void Display()

    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            
            job.DisplayDetails();
            
            job.Display();
        }
    }
}