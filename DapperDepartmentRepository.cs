using System;
using System.Text;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BestBuyCRUDTest
{
    public class DapperDepartmentRepository : IDepartmentRepository
    {
        //Field or local variable for making queries to the DB
        private readonly IDbConnection _connection;

        public DapperDepartmentRepository(IDbConnection connection)
        {

            //Constructor
            _connection = connection;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            var depos = _connection.Query<Department>("SELECT * FROM Departments").ToList();

            return depos;
        }

        public void InsertDepartment(string newDepartmentName)
        {
            _connection.Execute("INSERT INTO DEPARTMENTS (Name) VALUES (@departmentName);",
            new { departmentName = newDepartmentName });

        }
    }
}
