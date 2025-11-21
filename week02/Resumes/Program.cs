using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Palette Resort";
        job1._jobTitle = "Frotnt Desk Agent";
        job1._startYear = 2021;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Teleperformance";
        job2._jobTitle = "Bilingual Operations Agent ";
        job2._startYear = 2025;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Abraham Lopez";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
    
}