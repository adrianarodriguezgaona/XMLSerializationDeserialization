using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;


namespace XmlDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            MyConnection connection = new MyConnection();
            string filePath = @"D:\Klanten\MyTest";
            DataSerializer dataSerializer = new DataSerializer();
            List<Person>Persons = null;

            Persons = dataSerializer.XmlDeserialize(typeof(List<Person>), filePath) as List<Person>;

            foreach (Person person in Persons)
            {
                person.DateInsertSql = DateTime.Now;

                Console.WriteLine(connection.Insert(person.FirstName, person.LastName, person.Status.ToString(), person.DateInsertSql.ToString()));

                //Console.WriteLine(person.FirstName);
                //Console.WriteLine(person.LastName);
                //Console.WriteLine(person.Status);

            }

        }


    }
}
