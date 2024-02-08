using System;
using System.Runtime.Intrinsics.X86;

namespace BroCode_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://www.youtube.com/watch?v=RuhGv81tpoU

            //  Interface = define um "contrato" que todas as classes herdadas devem seguir
            //      Uma interface declara “o que uma classe deveria ter”
            //      Uma classe herdada define "como isso deve ser feito"
            
            //      Benefício = segurança + herança múltipla + "plug-and-play"

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            fish.Flee();
            fish.Hunt();
            Console.WriteLine("\n");

            hawk.Hunt();
            Console.WriteLine("");
            rabbit.Flee();

            Console.ReadKey();
        }
        interface IPrey
        {
            void Flee();
        }
        interface IPredator
        {
            void Hunt();
        }
        class Rabbit : IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit runs away!");
            }
        }
        class Hawk : IPredator
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk is searching for food! ");
            }
        }
        class Fish : IPrey, IPredator
        {
            public void Flee()
            {
                Console.WriteLine("The fish swims away");
            }

            public void Hunt()
            {
                Console.WriteLine("The fish is searching for smaller fish!");
            }
        }
    }
}
