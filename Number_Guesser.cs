using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_mid
{
    internal class Number_Guesser
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 100;
            Random random = new Random();
            Console.WriteLine("enter a number between " + min + " and " + max);
            int guess = Convert.ToInt32(Console.ReadLine());
            int number = random.Next(min, max);
            while (guess != number)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > number)
                {
                    Console.WriteLine("the number is smaller "); }
                else if (guess < number)
                {
                    Console.WriteLine("the number is bigger "); }
                else {
                    Console.WriteLine("u got it right!");


                }
            }

        }


    }
}


   

    