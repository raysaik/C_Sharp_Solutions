using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
                //var number = 10;
                //var dividend = 1000;
                //var result = dividend / (number - 100);
                //var strNum = "abcd";
                //var intVal = Convert.ToInt32(strNum);
                //throwFirstLayer();
                var people = new List<Person>();

                people.Add(new Person("John", "Doe"));
                people.Add(new Person("Jane", "Doe"));
                people.Sort();
                foreach (var person in people)
                    Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
            }
            
            catch(InvalidOperationException ioex)
            {
                var e = ioex;
            }
            catch(Exception ex)
            {
                var exp = ex;
            }
        }

        public static void throwFirstLayer()
        {
            throw new InvalidOperationException("manual");
        }
    }

    public class Person
    {
        public Person(String fName, String lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        public String FirstName { get; set; }
        public String LastName { get; set; }
    }
}
