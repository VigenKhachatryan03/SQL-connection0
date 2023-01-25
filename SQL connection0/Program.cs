using System;
using System.Data.SqlClient;

namespace SQL_connection0
{
    class Program
    {
        static string connection = "SERVER = (localdb)/mssqllocaldb; DATABASE = HomeWork01;";
         
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=HomeWork01;Integrated Security=True";
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                Console.WriteLine("Connection succsesful");

                Console.WriteLine("Enter your ID");
                int ID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your Name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your Age");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your Password");
                string Pass = Console.ReadLine();

                string insertQuerty = "" +
                    "insert into Users([ID] , [name], [username], [password])" +
                    "values(" + ID + ",'" + name+"', "+age+", '"+Pass+"')";
                SqlCommand insertCommand = new SqlCommand(insertQuerty, sqlConnection);
                insertCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }

        }
    }
}
