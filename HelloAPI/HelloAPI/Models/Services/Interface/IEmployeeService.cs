using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloAPI.Models.Services
{
    public interface IEmployeeService
    {
        List<JsonEmployee> GetAll();

        JsonEmployee GetById(int id);
    }
}
