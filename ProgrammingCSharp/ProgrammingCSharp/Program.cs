using System;

namespace ProgrammingCSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person1 = new Person();
            Person person2 = new Person("Diego");
            Person person3 = new Person("Luigi", "Sanchez");

            person1.FirstName = "Juan Camilo";
            Console.WriteLine("Person1: "+ person1.FirstName);
            Console.WriteLine("Person2: "+ person2.GetFullName());
            Console.WriteLine("Person3: "+ person3.GetFullName());


        }
    }


    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public byte Edad { get; set; }

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
            return FirstName+" "+LastName;
        }
        
    }
}
