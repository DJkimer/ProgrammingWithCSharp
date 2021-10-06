using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingCSharp
{
    static class EstructurasDeControl
    {
        public static void EstructuraIf()
        {
            int edad = 20;
            string mensaje = edad > 30 ? "Joven aún" : "Joven";
            if (edad > 30)
                mensaje = "Joven aún";
            else
                mensaje = "Joven";

        }

        public static void EstructuraSwitch()
        {
            int i = 10;
            string mensaje = "";
            switch (i)
            {
                case 10:
                    mensaje = "niño";
                    break;
                case 16:
                    mensaje = "adolecente";
                    break;
                case 21:
                    mensaje = "adulto";
                    break;
                default:
                    mensaje = "persona";
                    break;
            }
            Console.WriteLine(mensaje);
        }

        public static void EstructuraFor()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void EstructuraWhile()
        {
            int edad = 9;
            while (edad > 10)
            {
                Console.WriteLine("Hola!");
                edad++;
            }
        }

        public static void EstructuraDoWhile()
        {
            int edad = 9;
            do
            {
                Console.WriteLine("Hola!");
                edad++;
            } while (edad > 10);

        }

        public static void EstructuraTryCatch()
        {
            int edad = 23;
            string suma = "suma";
            try
            {
                edad += Int32.Parse(suma);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error de argumento");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Error de parceo");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                Console.WriteLine("Código finally");
            }
        }
    }
}
