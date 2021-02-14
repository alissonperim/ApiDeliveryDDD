using ApiDeliveryDDD.Application.Dtos;
using ApiDeliveryDDD.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ApiDeliveryDDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IApplicationServiceClient _service;

        public ClientController(IApplicationServiceClient service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post([FromBody] ClientDto model)
        {
            var result = _service.Add(model);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Put([FromBody] ClientDto model)
        {
            var result = _service.Update(model);
            return Ok(result);
        }

        [HttpGet]
        public IEnumerable<ClientDto> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
        public ClientDto Get(int id)
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
