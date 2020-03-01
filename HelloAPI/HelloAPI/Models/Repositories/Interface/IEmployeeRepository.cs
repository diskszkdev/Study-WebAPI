using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloAPI.Models.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();

        Employee GetById(int i);
    }
}
