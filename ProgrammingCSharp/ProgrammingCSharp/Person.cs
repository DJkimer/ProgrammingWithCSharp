using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingCSharp
{
    partial class Person
    {
        public int Identificacion { get; set; }

        public string Calle { get; set; }

        public string Numero { get; set; }


        public string GetDireccion()
        {
            return Calle + "" + Numero;
        }
    }
}
