using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SquadRegisterApi.Auxiliar;
using SquadRegisterApi.Models;
using SquadRegisterApi.Services.Contracts;

namespace SquadRegisterApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SquadController : ControllerBase
    {
        private readonly ISquadService _service;
        public SquadController(ISquadService _service)
        {
            this._service = _service;
        }

        [HttpPost]
        public async Task<ActionResult<Squad>> Insert([FromBody] Squad squad)
        {
            try
            {
                return Ok(await this._service.Insert(squad));
            }
            catch(Exception ex)
            {
                return UnprocessableEntity(ex.GetInnerException());
            }
        }
    }
}