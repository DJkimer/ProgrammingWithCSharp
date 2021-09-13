using System;

namespace ProgrammingCSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //variables
            //[datatype] [identifier];
            string customer;
            //[datatype] [identifier] = [value];
            string customeR = "Diego Ortiz";
            //Camel
            string customerFirstName = "";
            //constante
            const string name = "Diego";

            //Tipos númericos
            byte myByte = 255; //8 bits
            Byte myByteSystem = 255;  //8 bits
            short myShort = -32768; //16 bits
            int myInt; //32 bits
            long myLong; //64 bits

            //Númericos de punto flotante
            float myFloat;
            double myDouble;
            decimal myDecimal;

            //Boolean
            Boolean myBoolean;

            //Char
            char myChar = 'c';

            //Operadores aritmeticos

            int x = 5 % 2;

            //Operadores de comparación
            //< > <= >=

            //Igualdad
            //== !=

            //Operadores logicos 
            // ! && ||

            //Conversiones
            //1.Conversion Implicita, de tipos enteros pequeños a enteros más grandes.
            short myShort255_ = 255;
            int myInt16Bits = myShort255_;

            //2.Requieren casteo. eje. decimal to float (float).
            decimal myDecimal2 = 3;
            float myFloat2 = (float)myDecimal2;

            //3.Conversiones definidas por usuario - Conversión dada por reglas logicas.

            //4.Conversiones con clases del asisitente -  utilizada para tipos no compatibles cómo enteros a otros objetos
            int intParsed = int.Parse("5");
            int intConverted = Convert.ToInt32("5");  
            
            //TODO: finalizar clase.



        }
    }
}
