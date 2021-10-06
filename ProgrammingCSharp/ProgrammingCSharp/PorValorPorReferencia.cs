using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingCSharp
{
    static class PorValorPorReferencia
    {
        public static void AumentarContador(ref int numero)
        {
            numero += 10;
            Console.WriteLine(numero);
        }

        public static void ActualizarPersona(Person person) 
        {
            person.Email += "@gmail.com";
            Console.WriteLine(person.Email);
        }
    }
}
