using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolefordo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            String choice;
            do
            {
                Console.WriteLine("Enter the number");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine($"Table of {num} as follows");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num} * {i} = \t {(num * i)}");

                }
                Console.WriteLine("Do you wanna learn more press y yess or n no");
                choice = Console.ReadLine().ToLower();
            }
            while (choice == "y");
            
            
            
            
            
            
           


        }
    }
}
