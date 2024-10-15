using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssigment math = new MathAssigment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        WritingAssigment writing = new WritingAssigment("Mary Waters","European History","The Causes of World War II");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeWorkList());
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}