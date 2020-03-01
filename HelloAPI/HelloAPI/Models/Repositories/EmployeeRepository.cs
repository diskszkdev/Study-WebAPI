using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloAPI.Models.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                EmployeeId = 1,
                EmployeeName = "AAAA",
                Address = "",
                PhoneNumber = "",
                Remarks = "",
                Company = null
            },
            new Employee
            {
                EmployeeId = 2,
                EmployeeName = "BBBB",
                Address = "",
                PhoneNumber = "",
                Remarks = "",
                Company = null
            },
            new Employee
            {
                EmployeeId = 3,
                EmployeeName = "CCCC",
                Address = "",
                PhoneNumber = "",
                Remarks = "",
                Company = null
            }
        };

        public List<Employee> GetAll()
        {
            return employees;
        }

        public Employee GetById(int id)
        {
            return employees.Where(e => e.EmployeeId == id).SingleOrDefault();
        }
    }
}
