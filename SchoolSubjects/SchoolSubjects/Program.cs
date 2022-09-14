using System;
using System.Linq.Expressions;

namespace SchoolSubjects
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your favorite school subject?: ");
            var userInput = Console.ReadLine();

            switch(userInput.ToLower()) {
                case "math":
                    Console.WriteLine("You seem like a math wiz");
                    break;
                case "science":
                    Console.WriteLine("Next nobel prize winner eh?");
                    break;
                case "history":
                    Console.WriteLine("I like history too. Most of it is death and destruction");
                    break;
                case "english":
                    Console.WriteLine("Oh you like English? Name every word");
                    break;
                case "music":
                    Console.WriteLine("Can you play your scales for me?");
                    break;
                default:
                    Console.WriteLine("Sorry I didn't get that");
                    break;
            }
            
        }
    }
}