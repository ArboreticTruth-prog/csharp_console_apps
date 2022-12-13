using System;
using static Fizzing;
using static DivideTheTwo;
using static Priming;
namespace main 
{
    class MainProgram
    {
        static void Main (string[] args)
        {   
            Console.WriteLine("Lets Play A Game Of FizzBuzz!" + "\n");
            Buzzing();
            Console.WriteLine("\n");
            Console.WriteLine("That Was Easy! Lets Try Something Different..." +"\n");
            Divide();
            Console.WriteLine("  ");
            Factoring();

            
        }
    }
}