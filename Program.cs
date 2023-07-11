using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7GOTO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username;
            Again:
            Console.WriteLine("enter USer name");
            username = Console.ReadLine();
            if (username.Length >= 6)
            {
                Console.WriteLine("Welcome:\t" + username);

            }
            else
            {
                Console.WriteLine("Invalid User name");
                goto Again;
            }
            Console.ReadKey();


        }
    }
}
