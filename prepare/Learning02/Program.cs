using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "America First Federal Credit Union";
        job1._jobTitle = "Teller";
        job1._startYear = 2022;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Kentucky Fried Chicken";
        job2._jobTitle = "Cook";
        job2._startYear = 2010;
        job2._endYear = 2021;

        Resume myresume= new Resume();
        myresume._name = "Emilie Gorder";
        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);

        myresume.DisplayResume();
    }
}