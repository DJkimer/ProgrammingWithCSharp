using System;

namespace ProgrammingCSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Perro perro = new Perro();
            perro.Comer();
            perro.Ladrar();

            Gato gato = new Gato();
            gato.Comer();
            gato.Name = "Felix";
            Console.WriteLine(gato.HacerUnTruco());

            Person person = new Person();
            Employee employee = new Employee();
            employee.ID = 1;
            employee.Office = "Office 302";
            employee.Identificacion = 123;
            employee.FirstName = "Employee";
            employee.LastName = "LastNameEmployee";
            employee.Calle = "54 sur";
            employee.Numero = "74";
            Console.WriteLine(employee.GetFullName());
            Console.WriteLine(employee.GetDireccion());


            Colecciones.ColeccionArray();

            EstructurasDeControl.EstructuraTryCatch();
            string name = "Can I use this \"string\" within the string?";            
            string name2 = "Can I use this \"string\" within \\ the string?"; //Can I use this "string" within \ the string?
            string name3 = "Can I use this \"string\" within \\\\ the string?"; //Can I use this "string" within \\ the string?
            string name4 = @"Can I use this within \\Bog-dev\asdf\asd\ the string?"; //Can I use this "string" within \\\\ the string?
            name = name2 + " __" + name4;
            int edad = 24;

            Console.WriteLine("Hello World!");
            Person person1 = new Person();
            Person person2 = new Person("Diego");
            Person person3 = new Person("Luigi", "Sanchez");
            person2.Email = "diego";
            int contador = 14;
            Console.WriteLine(contador);
            Console.WriteLine(person2.Email);
            Console.WriteLine("Actualizando valores...");
            PorValorPorReferencia.ActualizarPersona(person2);
            PorValorPorReferencia.AumentarContador(ref contador);
            Console.WriteLine("Terminado...");
            Console.WriteLine(contador);
            Console.WriteLine(person2.Email);
            person1.FirstName = "Juan Camilo";
            person1.Calle = "#";
            person1.Numero = "9";
            person1.Edad = 15;            
            Console.WriteLine("Full Name y Edad "+ person1.GetFullName());
            Console.WriteLine("Catagoria: "+ (int)Categorias.Drinks);            
            Console.WriteLine("Person1 Direccion: "+ person1.GetDireccion());
            Console.WriteLine("Person1: "+ person1.FirstName);
            Console.WriteLine("Person2: "+ person2.GetFullName());
            Console.WriteLine("Person3: "+ person3.GetFullName());
            int sum = StaticClass1.GetSum(2, 5);



        }
    }


    public partial class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public  byte Edad { get; set; }

        public Person()
        {

        }

        public Person(string firstName, string lastName = "NN")
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFullName()
        {
            int GetEdadPor10()
            {
                return Edad * 10;
            }
            return FirstName+" "+LastName + "Edad x 10 :" + GetEdadPor10();
        }
        
    }
}
