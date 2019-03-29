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
            this.Name = name;
            this.Age = age;
            Legs = 0;
            Species = "shark";
            this.Status = status;
        }
    }

    public class Cat : Animal
    {
        public Cat(string name, int age, string status) : base(name, age, status)
        {
            this.Name = name;
            this.Age = age;
            Legs = 4;
            Species = "cat";
            this.Status = status;
        }

        public void Introduce() =>
            Console.WriteLine("Hello, my name is" +this.Name+ "and I am" + this.Age + "years old.  Meow meow!");
    }

    public class Dog : Animal
    {
        string Master;
        public Dog(string name, int age, string status, string master) : base(name, age, status)
        {
            this.Name = name;
            this.Age = age;
            Legs = 4;
            Species = "Dog";
            Master = master;
            this.Status = status;
        }
        public string GreetMaster()
        {
            return $"Hello "+Master;
        }
    }
}
