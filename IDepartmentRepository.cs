using System;
using System.Text;
using System.Collections.Generic;

namespace BestBuyCRUDTest
{
    public interface IDepartmentRepository
    {
        //Saying we need a method called GetALLDEparments that returns a method
        //that conforms to IEnumerable<T>

        IEnumerable<Department> GetAllDepartments();

        void InsertDepartment(string newDepo);
    }

    
}
