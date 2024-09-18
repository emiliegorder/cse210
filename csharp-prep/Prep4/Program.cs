using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        while(number != 0)
        {
            Console.Write("Enter Number:");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        int total = numbers.Sum();
        Console.WriteLine($"The sum is {total}");
        double average = numbers.Average();
        Console.WriteLine($"The average is {average}.");
        int max = numbers.Max();
        Console.WriteLine($"The largest number is {max}");
    }
}