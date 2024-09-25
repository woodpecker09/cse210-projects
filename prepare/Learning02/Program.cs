using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        
        Job job1 = new Job();
        myResume._jobs.Add(job1);
        myResume._jobs[0]._company = "Microsoft";
        myResume._jobs[0]._jobTitle = "Software Engineer";
        myResume._jobs[0]._startYear = 2019;
        myResume._jobs[0]._endYear = 2022;
    
        Job job2 = new Job();
        myResume._jobs.Add(job2);
        myResume._jobs[1]._company = "Apple";
        myResume._jobs[1]._jobTitle = "Manager";
        myResume._jobs[1]._startYear = 2022;
        myResume._jobs[1]._endYear = 2023;

        myResume.DisplayResume();

    }
}