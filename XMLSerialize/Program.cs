using ClassLibrary1;
using System;
using System.IO;
using System.Xml.Serialization;

namespace XMLSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Adriana", "Maria", true);
            string filePath = @"D:\Klanten\MyTest";
            DataSerializer dataSerializer = new DataSerializer();
           
            dataSerializer.XmlSerialize(typeof(Person), person, filePath);
            

            //Console.WriteLine(filePath);


        }


    }
}
