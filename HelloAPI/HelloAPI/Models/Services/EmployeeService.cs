using HelloAPI.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloAPI.Models.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService() : this(new EmployeeRepository()) { }

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public List<JsonEmployee> GetAll()
        {
            try
            {
                var result = _repository.GetAll();
                var jsonData = result.Select(r => new JsonEmployee
                {
                    EmployeeId = r.EmployeeId,
                    EmployeeName = r.EmployeeName,
                    Address = r.Address
                }).ToList();

                return jsonData;
            }
            catch (Exception)
            {
                return new List<JsonEmployee>();
            }
        }

        public JsonEmployee GetById(int id)
        {
            try
            {
                var result = _repository.GetById(id);
                return new JsonEmployee
                {
                    EmployeeId = result.EmployeeId,
                    EmployeeName = result.EmployeeName,
                    Address = result.Address
                };
            }
            catch (Exception)
            {
                return new JsonEmployee();
            }
        }
    }
}