using System;

class Program
{    static void Main(string[] args)
    {
        Random  numberGenerator = new Random();
        int magicNumber = numberGenerator.Next(1,100);
        int guess = -1;
        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
            if (guess > magicNumber){
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine("Higher");
            }
        }
        Console.WriteLine("You got it!");
    }
}