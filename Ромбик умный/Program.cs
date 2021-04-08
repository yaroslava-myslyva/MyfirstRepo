using System;

namespace Ромбик_умный
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *    **
             *   ****
             *  ******
             *  ******
             *   ****
             *    **
             */
            while (true)
            {
                Console.WriteLine("Please enter the height of your rhombus.");
                int height = int.Parse(Console.ReadLine());
                int first = height;
                while (first > 2)
                {
                    first = first - 2;
                }
                int now = first;
                int line = 1;
                while (line <= height)
                {
                    int spase = (height - now) / 2;
                    while (spase > 0)
                    {
                        Console.Write(" ");
                        spase--;
                    }
                    int stars = now;
                    while (stars > 0)
                    {
                        Console.Write("*");
                        stars--;
                    }
                    if (line < 0.5 * height)
                    {
                        now = now + 2;
                    }
                    else if (line == 0.5 * height)
                    {
                    }
                    else
                    {
                        now = now - 2;
                    }

                    

                    Console.WriteLine();
                    line++;
                }
            }



        }
    }
}
