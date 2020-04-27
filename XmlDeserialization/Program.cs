using ClassLibrary1;
using System;
using System.IO;
using System.Xml.Serialization;

namespace XmlDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string filePath = @"D:\Klanten\MyTest";
            DataSerializer dataSerializer = new DataSerializer();
            Person person = null;

            person = dataSerializer.XmlDeserialize(typeof(Person), filePath) as Person;

            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);

        }


    }
}
