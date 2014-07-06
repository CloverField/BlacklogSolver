using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            System.Console.WriteLine("Your random number is " + rand.Next(1, 20) + ".");
            System.Console.WriteLine("Press enter to terminate the program.");
            System.Console.ReadLine();
        }
    }
}
