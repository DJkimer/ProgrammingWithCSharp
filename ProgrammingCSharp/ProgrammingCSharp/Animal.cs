using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingCSharp
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public virtual void Comer()
        {
            Console.WriteLine("Animal comiendo...");
        }
        public abstract string HacerUnTruco();
    }
}
