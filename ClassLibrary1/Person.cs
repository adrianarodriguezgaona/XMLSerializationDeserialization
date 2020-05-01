using System;

namespace ClassLibrary1
{
    [Serializable]
    public class Person
    {
   
        public string FirstName { get; set; }
        public string  LastName { get; set; }

        public bool Status { get; set; }

        public DateTime DateInsertSql { get; set; }

        public Person()
        {

        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }

        public Person(string firstName, string lastName,bool status):this (firstName ,  lastName)
        {
            Status = status;
        }

        public Person (string firstName, string lastName, bool status , DateTime date):this (firstName, lastName,status)
        {
            DateInsertSql = date;
        }
        

    }

}
