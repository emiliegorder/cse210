using System;

class Program
{
    static void Main(string[] args)
    {
        string userName = PromptUserName();
        int userNumber= PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please Enter Your name:");
        string yourName = Console.ReadLine();
        return yourName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please Enter Your Favorite Number:");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name} the sqaure of your number is {square}");
    }
}