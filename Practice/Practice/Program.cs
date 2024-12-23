using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal tiger = new Tiger();
            Animal parrot = new Parrot();
            Animal shark = new Shark();

            //Method calls and classes
            //Tiger01
            Console.WriteLine("Tiger Behavior:");
            tiger.Eat();
            tiger.Sleep();
            tiger.Move();
            tiger.MakeSound();
         


            //Method calls and classes
            //Parrot02
            Console.WriteLine("\n Parrot Behavior:");
            parrot.Eat();
            parrot.Sleep();
            parrot.Move();
            parrot.MakeSound();
            

            //Method calls and classes
            //Shark03
            Console.WriteLine("\n Shark Behavior:");
            shark.Eat();
            shark.Sleep();
            shark.Move();
            shark.MakeSound();
        
        }
    }
}
