using System;

class Program
{
    static void Main(string[] args)
    {
        Job job_one = new Job();
        job_one.jobTitle = "";
        job_one.company = "";
        job_one.startYear = ;
        job_one.endYear = ;

        Job job_two = new Job();
        job_two.jobTitle = "";
        job_two.company = "";
        job_two.startYear = ;
        job_two.endYear = ;

        Resume officalResume = new Resume();
        officalResume.name = "";
        Resume.job_career.Add(job_one);
        Resume.job_career.Add(job_two);

        officalResume.Display();
    }
}

public class Job
{
    string company;
     public Job(string jt) {
        company = jt;
    }

   string jobTitle;
     public Job(string jtt) {
        jobTitle = jtt;
    }

   string startYear;
     public Job(int sy) {
        startYear = sy;
    }

   int endYear;
     public Job(int ey) {
        endYear = ey;
    }
}

public class Resume
{
    public string _name;

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}