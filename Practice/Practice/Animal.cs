using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal interface Animal
    {
        void Eat();
        void Sleep();
        void Move();
        void MakeSound();

    }
    //Tiger01
    public class Tiger : Animal
    {
        public void Eat()
        {
            Console.WriteLine("Tiger is eating buffalo.");
        }
        public void Sleep()
        {
            Console.WriteLine("Tiger is Sleeping.");
        }
        public void Move()
        {
            Console.WriteLine("The tiger prowls silently through the jungle.");
        }
        public void MakeSound()
        {
            Console.WriteLine("The tiger roars loudly.");
        }
    }
    //Parrot02
    public class Parrot : Animal
    {
        public void Eat()
        {
            Console.WriteLine("The parrot eats seeds and fruits.");
        }
        public void Sleep()
        {
            Console.WriteLine("Parrots sleep in nests.");
        }
        public void Move()
        {
            Console.WriteLine("Parrot perch while moving with agility");
        }
        public void MakeSound()
        {
            Console.WriteLine("Parrots chirp, squawk, mimic sounds, and even imitate human speech.");
        }
    }
    //shark03
    public class Shark : Animal
    {
        public void Eat()
        {
            Console.WriteLine("The shark eat fish, squid, seals, and marine creatures, using sharp teeth.");
        }
        public void Sleep()
        {
            Console.WriteLine("The shark rest while swimming, some need water flowing over gills.");
        }
        public void Move()
        {
            Console.WriteLine("The shark swims swiftly through the ocean.");
        }
        public void MakeSound()
        {
            Console.WriteLine(" The shark are silent; they communicate through body language, not sounds.");
        }
    }


}
