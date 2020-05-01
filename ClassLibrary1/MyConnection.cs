using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace ClassLibrary1
{
    public class MyConnection
    {

        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader dr;

        public MyConnection()
        {
            try
            {
                connection = new SqlConnection("Server=.\\sqlexpress;Database=Klanten;Integrated Security=true;");
                connection.Open();
                Console.WriteLine("conectado");

            }

            catch (Exception ex)
            {
                Console.WriteLine("No se encontro la base de datos: " + ex.ToString());


            }
        }
        public string Insert(string firstName, string lastName, string status, string date)
        {
            string answer = "Successfully inserted";

            try
            {
                cmd = new SqlCommand("Insert into Persoons (firstname,lastName,statuspersoon,insertdatum)values('" + firstName + "','" + lastName + "','" + status + "','" + date + "')",connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                answer = "Not connected!" + ex.ToString();
            }

            return answer;

        }
        // Yo can use this method for validation if user is able to insert id in a form for example
        public int RegisteredPersoon (int id)
        {
            int counter = 0;
            try
            {
                cmd = new SqlCommand("Select * from Persoons where Id=" + id + "", connection);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    counter++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine("It could not read: " + ex.ToString());
            }
            return counter;
           
        }
    }
}
