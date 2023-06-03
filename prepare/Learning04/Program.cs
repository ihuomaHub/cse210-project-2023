using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("John Ihuoma Anochirionye");
        assignment1.SetTopic("Multiplication");

        Console.WriteLine();
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        /*MathAssignment assignment2 = new MathAssignment();
        assignment2.SetStudentName("Regina Charles");
        assignment2.SetTopic("Maths Division");
        assignment2.SetTextbookSection("Section 7.3");
        assignment2.SetProblem("Problem 8-19");

        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment assignment3 = new WritingAssignment();
        assignment3.SetStudentName("Regina Okams");
        assignment3.SetTitle("The Cause of World War 11 by Mary Waters");

        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());*/
    }
}