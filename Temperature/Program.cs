using System;

namespace Temperature
{
    class Temp
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter the F value: ");
            double F =double.Parse(Console.ReadLine());
            double c;
            c = (F - 32) * 5 / 9;
            Console.WriteLine("The value of c:" +c);
            if(c > 37)
            {
                Console.WriteLine($"The user is ill");
            }
            else
            {
                Console.WriteLine($"Everything is fine");
            }

        }
    }
}
