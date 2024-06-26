﻿using System;
using Dapper;
using DataAcess.Models;
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
                var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
                foreach (var category in categories)
                {
                    Console.WriteLine($"{category.Id} - {category.Title}");
                }
            }

            Console.WriteLine("Hello world!");
        }
    }
}
