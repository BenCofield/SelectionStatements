using System;

namespace GuessingGame
{
    class Program
    {
        static void Main()
        {
            var randomNum = new Random();
            var favoriteNum = randomNum.Next(1, 10);

            while(true)
            {
                Console.Write("Guess a number between 1 and 10: ");
                var guess = int.Parse(Console.ReadLine());
            
                if (guess > favoriteNum)
                {
                    Console.WriteLine("Too high");
                }
                else if (guess < favoriteNum)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    Console.WriteLine("You guessed correctly!");
                    break;
                }
            }
        }
    }
}