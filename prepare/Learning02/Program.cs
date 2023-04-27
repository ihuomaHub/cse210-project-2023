using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2017;
        job1._endYear = 2023;

        job1.DisplayJobDetails();
        

        Job job2 = new Job();
        job2._jobTitle = "Cyber Security Engineer";
        job2._companyName = "Apple";
        job2._startYear = 2020;
        job2._endYear = 2023;

        job2.DisplayJobDetails();
    }
}