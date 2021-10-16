using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingCSharp
{
    class Colecciones
    {
        public static void ColeccionArray()
        {
            string[] nombres = new string[5];
            nombres[0] = "Maryluz1";
            nombres[1] = "Maryluz2";
            nombres[2] = "Maryluz3";
            nombres[3] = "Maryluz4";
            nombres[4] = "Maryluz5";
            int[] edades = {1,2,3,4,5};
            edades[2] = 6; //{1,2,6,4,5}
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine(edades[i]);
            }
            Array.Sort(edades);
            Console.WriteLine("");
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine(edades[i]);
            }
        }

        public static void ColeccionList()
        {
            List<string> nombres = new List<string>();
            nombres.Add("Yadier");
            List<string> nombres2 = new List<string> {"Juan","Edwin","Luigi","Maryluz" };
            nombres.AddRange(nombres2);
            for (int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine(nombres[i]);
            }
            List<Person> people = new List<Person>();
            Person person = new Person
            {
                FirstName = "",
                LastName = "",
                Identificacion = 123
            };
            people.Add(person);
        }

        public static void ColeccionDiccionarios()
        {
            Dictionary<int, string> firstDictionary = new Dictionary<int, string>();
            firstDictionary.Add(1, "A");
            firstDictionary.Add(2, "A");
            firstDictionary.Add(3, "B");
            firstDictionary.Add(4, null);
            firstDictionary.Add(5, "D");
            Dictionary<Guid, Person> directorioPersonar = new Dictionary<Guid, Person>();
            var unNull = firstDictionary[4];

            foreach (KeyValuePair<int, string> item in firstDictionary)
            {
                Console.WriteLine(item.Value + " " + item.Key);
            }
        }

    }
}
