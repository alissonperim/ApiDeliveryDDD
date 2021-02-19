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
        public async Task<IActionResult> Post([FromBody] ClientDto model)
        {
            var result = await _service.Add(model);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ClientDto model)
        {
            var result = await _service.Update(model);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IEnumerable<ClientDto>> Get()
        {
            return await _service.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ClientDto> Get(int id)
        {
            return await _service.GetById(id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(ClientDto model)
        {
            return Ok(await _service.Remove(model));
        }
    }
}
