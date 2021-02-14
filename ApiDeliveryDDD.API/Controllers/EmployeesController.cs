using ApiDeliveryDDD.Application.Dtos;
using ApiDeliveryDDD.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDeliveryDDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IApplicationServiceEmployee _service;
        public EmployeesController(IApplicationServiceEmployee service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post([FromBody] EmployeeDto model)
        {
            var result = _service.Add(model);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Put([FromBody] EmployeeDto model)
        {
            var result = _service.Update(model);
            return Ok(result);
        }

        [HttpGet]
        public IEnumerable<EmployeeDto> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
        public EmployeeDto Get(int id)
        {
            return _service.GetById(id);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_service.Remove(id));
        }
    }
}
