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
        public async Task<IActionResult> Post([FromBody] EmployeeDto model)
        {
            var result = await _service.Add(model);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] EmployeeDto model)
        {
            var result = await _service.Update(model);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeDto>> Get()
        {
            return await _service.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<EmployeeDto> Get(int id)
        {
            return await _service.GetById(id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(EmployeeDto employeeDto)
        {
            return Ok(await _service.Remove(employeeDto));
        }
    }
}
