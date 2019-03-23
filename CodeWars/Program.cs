using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ReadLine();
        }
    }
    public class Animal
    {
        public int Age;
        public int Legs;
        public string Name;
        public string Species;
        public string Status;

        public Animal(string name, int age, string status)
        {
            Name = name;
            Age = age;
            Status = status;
        }

        public Animal(string name, int age, int legs, string species, string status)
        {
            this.Name = name;
            this.Age = age;
            this.Legs = legs;
            this.Species = species;
            this.Status = status;
        }

        public virtual string Introduce()
        {
            return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
        }
    }
    public class Shark : Animal
    {
        public Shark(string name, int age, string status) : base(name, age, status)
        {
            Legs = 0;
            Species = "shark";
        }
    }

    public class Cat : Animal
    {
        // Do the same here as you did for Shark - define your constructor function and any other methods you need
    }

    public class Dog : Animal
    {
        // On your own now - you can do it :D
    }
}
