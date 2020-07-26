using System;
using System.Data;
using System.IO;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace BestBuyCRUDTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");
            Console.WriteLine(connString);
            

            IDbConnection conn = new MySqlConnection(connString);
            DapperDepartmentRepository repo = new DapperDepartmentRepository(conn);

            Console.WriteLine("Hello user, here are the current departments:");
            var depos = repo.GetAllDepartments();

            foreach (var depo in depos)
            {
                Console.WriteLine($"ID: { depo.DepartmentID} Name: { depo.Name}");
            }

            Console.WriteLine("Do you want to add a department?????");
            string userResponse = Console.ReadLine();

            if (userResponse.ToLower()== "yes")
            {
                Console.WriteLine("What is the name of your new Department?????");
                userResponse = Console.ReadLine();

                repo.InsertDepartment(userResponse);
                repo.GetAllDepartments();

            }

            Console.WriteLine("Have a great day.");
            Console.WriteLine("Press Enter To Continue!!!!!");
            Console.ReadLine();

            

        }
    }
}
