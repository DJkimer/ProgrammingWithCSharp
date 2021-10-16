using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingCSharp
{
    public class Employee : Person
    {
        public int ID { get; set; }
        public string Office { get; set; }

        public override string GetDireccion()
        {
            return Calle + "" + Numero+" Office: " +Office;
        }

    }
}
