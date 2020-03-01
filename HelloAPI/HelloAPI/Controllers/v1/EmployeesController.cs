using System.Collections.Generic;
using HelloAPI.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace HelloAPI.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _service;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public EmployeesController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<JsonEmployee>> GetAll()
        {
            var result = _service.GetAll();
            return result;
        }

        [HttpGet("{id}")]
        public ActionResult<JsonEmployee> GetById(int id)
        {
            var result = _service.GetById(id);
            return result;
        }

        [HttpPost]
        public ActionResult Create([FromBody]JsonEmployee employee)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody]JsonEmployee employee)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}