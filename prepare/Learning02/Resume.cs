using System;
using System.Security.Cryptography.X509Certificates;
public class Resume
{
    public string name;
    public List<Job> jobs;

    public void Display()
    {
        Console.WriteLine(name);
        foreach (Job job in jobs)
        { 
            job.Display();
        }
    }
    public Resume(string name,List<Job> jobs)
    {
        this.name = name;
        this.jobs = jobs;
    } 
    
}