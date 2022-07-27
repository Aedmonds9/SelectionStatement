using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 7;
            Console.WriteLine("Hello, try to guess my favorite number!");
            int userGuess = int.Parse(Console.ReadLine());
            if (userGuess <= favNumber) ;
            {
                Console.WriteLine("Too Low! Try Again!");
            }
            else if (userGuess >= favNumber) ;
            {
                Console.WriteLine("Too high! Try again!");
            }
        }
    }
}
