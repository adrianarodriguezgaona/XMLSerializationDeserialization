using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Timers;
using System.Xml.Serialization;

namespace XMLSerialize
{
    class Program
    {
        private static Timer aTimer;

        static List<Person> Persons = new List<Person>();

        static bool status = true;

        static void Main(string[] args)
        {
           
            //Console.WriteLine(filePath);

             
            // Create a timer and set a two second interval.
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 5000;

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;

            Console.WriteLine("Press the Enter key to exit the program at any time... ");
            Console.ReadLine();
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            string[] firstNamesArray = { "Paulo", "Adriana", "Diego", "Juanillo", "Pedro", "Silvia", "Monica" };

            string[] lastNamesArray = { "Rodriguez", "Gaona", "Jimenez", "Perez", "Galindo", "Corredor", "Pinto" };

            var rnd = new Random();
            var index = 0;
           

            int fNameIndex = rnd.Next(firstNamesArray.Length);
            int lNameIndex = rnd.Next(lastNamesArray.Length);

            if (Persons.Count > 0)
            {              
                index = Persons.Count - 1;
                status = !Persons[index].Status;
            }

            Person person = new Person(firstNamesArray[fNameIndex], lastNamesArray[lNameIndex], status);

            Persons.Add(person);

            string filePath = @"D:\Klanten\MyTest";

            DataSerializer dataSerializer = new DataSerializer();

            dataSerializer.XmlSerialize(typeof(List<Person>),Persons, filePath);

            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
        }
    }


    
}
