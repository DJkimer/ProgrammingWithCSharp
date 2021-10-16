using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingCSharp
{
    public class Perro:Animal
    {
        public int Edad { get; set; }
        public string Raza { get; set; }

        public void Ladrar()
        {
            Console.WriteLine("Guau!");
        }

        public override void Comer()
        {
            Console.WriteLine("Perro comiendo...");
        }

        public override string HacerUnTruco()
        {
            return "Da la pata";
        }
    }
}
