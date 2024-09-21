using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int userInterFace = -1;
        int sumNumbers = 0;
        while (userInterFace != 0)
        {
            Console.Write("Enter number: ");
            userInterFace = int.Parse(Console.ReadLine());
            if (userInterFace != 0)
            {
                numbers.Add(userInterFace);
            }

        }
        foreach (int number in numbers)
            {
               sumNumbers += number; 
            }
        float avgNumber = ((float)sumNumbers) / numbers.Count;
        Console.WriteLine($"The average number is: {avgNumber}");
        Console.WriteLine($"The sum is: {sumNumbers}");
        numbers.Sort();
        Console.WriteLine($"The largest number is: {numbers[numbers.Count-1]}");
        int smallestNumber = numbers[numbers.Count-1];
        foreach (int number in numbers)
            {
                if (number < smallestNumber && smallestNumber >= 0)
                    {
                        smallestNumber = number;
                    }
            }
        if (smallestNumber >= 0)
            {   
                Console.WriteLine($" The smallest positive number is: {smallestNumber}");
            }
        else
            {
                Console.WriteLine("the smallest number is not positive");
            }
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
            {
                Console.WriteLine($"{number}");
            }
    }
}