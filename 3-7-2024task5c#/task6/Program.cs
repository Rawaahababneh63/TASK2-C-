using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        interface ISound
        {
            void MakeSound();
        }

        public abstract class Animal
        {
            public   string Name { get;  private set; }
            public Animal(string name) {
                Name = "soso";
            }
            public abstract void Eat();
            public abstract void Sleep();

        }

        public class Dog : Animal, ISound
        {
            public Dog(string name) : base(name)
            {

            }

            public override void Eat() { Console.WriteLine($"Animal {Name} is eating chiken"); }
            public override void Sleep()
            {
                Console.WriteLine($"{Name} is sleeping");
            }

            public void MakeSound()
            {
                Console.WriteLine("Dog sound is Woof!");
            }

        }

        public class Cat : Animal, ISound
        {
            public Cat(string name) : base(name)
            {

            }

            public override void Eat() { Console.WriteLine($"Animal {Name} is eating leaf"); }
            public override void Sleep()
            {
                Console.WriteLine($"{Name} is sleeping");
            }

            public void MakeSound()
            {
                Console.WriteLine("The cat's sound is Meow!");
            }


        }

        /// ////////////////////////////////////////////////////////////////////////////////////////
        //task2
        public  class Cars
        {
            public int Year { get; set; }
            public int Make { get; set; }
            public string Type { get; set; }
            public double Price { get; set; }
            public string Model { get; set; }
            public double PalletNo { get; set; }
            public string Color { get; set; }

            void DisplayInfo(double make,double year) {
                Console.WriteLine($"The information Car: Make {make} ,Year :{year}");
                    }
          
            void DisplayInfo(double make)
            {
                Console.WriteLine($"The information Car: Make {make} ");
            }
        public virtual void Display()
            {
                Console.WriteLine("Welcome Car ");
            }
 }
        public class BMW : Cars
        {

         public override void Display()
            {
                Console.WriteLine("Welcome BMW");
            }


        }
       //modify task2 with overriding concept


        static void Main(string[] args)
            {

                Dog dog = new Dog("Buddy");
                dog.MakeSound();
                dog.Sleep();
                dog.Eat();
                Console.WriteLine($" The dog name is {dog.Name}");

                Cat cat = new Cat("Whiskers");
                cat.MakeSound();
                cat.Sleep();
                cat.Eat();
                Console.WriteLine($" The cat's name is {cat.Name}");


            //لما ما أعمل ovrriding  رح يعطيني اثر الاب ومعلوماته مش الابن
            //لحل هاي المشكلة بروح بعمل  لاب فيرتشوال والابن بحط عنده اوفررادينج
            Animal cat1 = new Cat("Lousi");
            Console.WriteLine( cat1.Name);
            /////////
            ///
            //task2
            BMW bMW = new BMW();
           bMW.Display();
            //modify for this topic
          Cars bmw1 = new BMW();
          bmw1.Display();
        }
        }
    } 
