using Assigment.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth Year:");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            Calculate_Age agecalculator = new Calculate_Age(birthYear);
            int Age = agecalculator.Agecalculate();

            Console.WriteLine("Your Age is:" + Age);
            Console.ReadLine();

        }
    }
   
}
