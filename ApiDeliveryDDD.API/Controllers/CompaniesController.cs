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
    public class CompaniesController : ControllerBase
    {
        public IApplicationServiceCompany _service;
        public CompaniesController(IApplicationServiceCompany service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CompanyDto model)
        {
            var result = _service.Add(model);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Put([FromBody] CompanyDto model)
        {
            var result = _service.Update(model);
            return Ok(result);
        }

        [HttpGet]
        public IEnumerable<CompanyDto> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
        public CompanyDto Get(int id)
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
