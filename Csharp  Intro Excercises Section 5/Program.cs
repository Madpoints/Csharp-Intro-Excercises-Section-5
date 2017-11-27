using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp__Intro_Excercises_Section_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Checks user input to see if the number given is between 1 and 10
            Console.WriteLine("Give me a number between 1 and 10");
            string numberString = Console.ReadLine();
            int number = Convert.ToInt32(numberString);

            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            //2. Takes two numbers from the console and displays the maximum of the two
            Console.WriteLine("Give me two numbers and I'll tell you which one is bigger");
            string numberStringA = Console.ReadLine();
            int numberA = Convert.ToInt32(numberStringA);
            string numberStringB = Console.ReadLine();
            int numberB = Convert.ToInt32(numberStringB);

            if (numberA > numberB)
            {
                Console.WriteLine("{0} is bigger than {1}", numberA, numberB);
            }
            else
            {
                Console.WriteLine("{0} is bigger than {1}", numberB, numberA);
            }

            //3. Ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait
            Console.WriteLine("Give me a height then a width");
            var height = Convert.ToInt32(Console.ReadLine());
            var width = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("Landscape");
            }
            else
            {
                Console.WriteLine("Portrait");
            }

            //4.
        }
    }
}
