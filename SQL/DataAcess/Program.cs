using System;
using Microsoft.Data.SqlClient;

namespace DataAcess
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,1433;Database=balta;User Id=sa;Password=1q2w3e4r@#$;TrustServerCertificate=true";

            
            using (var connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Connect");
                connection.Open();
                
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT [Id], [Title] FROM [Category]";

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
                    }
                }
            }

            Console.WriteLine("Hello world!");
        }
    }
}
