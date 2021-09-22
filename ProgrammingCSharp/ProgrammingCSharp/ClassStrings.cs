using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingCSharp
{
    class ClassStrings
    {
        public void StringCaracteresEspeciales()
        {
            string caracteresEsp = "abc \"d\" ef"; //abc "d" ef
            string caracteresEsp2 = "abc \\d\\ ef"; //abc \d\ ef
            string caracteresEsp3 = "D:\\FumiNi\\Cursos\\C#\\03. Tipos de datos no primitivos"; // D:\FumiNi\Cursos\C#\03. Tipos de datos no primitivos
            string caracteresEsp4 = @"D:\FumiNi\Cursos\C#\03. Tipos de datos no primitivos"; // D:\FumiNi\Cursos\C#\03. Tipos de datos no primitivos

        }
        public void StringsConcatenados()
        {
            string segundoApellido = "Zuleta";
            string nombre = "Diego Javier";
            nombre = nombre + " Ortiz" +" "+ segundoApellido;
        }

        public void StingsInterpolacion()
        {
            int edad = 45;
            string nombre = "John";
            string curso = "C#";
            Console.WriteLine($"Edad: {edad} nombre: {nombre} curso: {curso} suma:{edad+10*2}");
        }

        public void StringBuliderMetodh()
        {
            StringBuilder builder = new StringBuilder("John");
            builder.Append(" Wick");
            builder.AppendLine("Edad: 45");
            /*
             John Wick
             Edad: 45
             */
            Console.WriteLine(builder.ToString());
            //insert
            builder.Insert(3," SugundoNombre");
            /*
             012345678
             John SugundoNombre Wick
             Edad: 45
             */
            Console.WriteLine(builder.ToString());

            //remove
            builder.Remove(3, 14);
            /*
             012345678
             John Wick
             Edad: 45
             */
            Console.WriteLine(builder.ToString());
            //replace
            builder.Replace('c', 's');
            builder.Replace("Edad", "Age");
            Console.WriteLine(builder.ToString());
            /*
             012345678
             John Wisk
             Age: 45
             */
        }

    }
}
