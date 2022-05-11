using System.Collections.Generic;

namespace JobBoard.Models
{
  public class Job
  {
    public string Title {get; set;}
    public string Description {get; set;}
    public string ContactNumber {get; set;}
    public int Id {get;}

    private static List<Job> _jobs = new List<Job>();

    public Job(string title, string description, string number)
    {
      Title = title;
      Description = description;
      ContactNumber = number;
      _jobs.Add(this);
      Id = _jobs.Count;
    }

    public static List<Job> GetJobs()
    {
      return _jobs;
    }

    public static Job Find(int searchId)
    {
      return _jobs[searchId-1];
    }

  }
}