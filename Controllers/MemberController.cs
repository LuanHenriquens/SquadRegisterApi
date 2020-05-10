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
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _service;
        public MemberController(IMemberService _service)
        {
            this._service = _service;
        }

        [HttpPost]
        public async Task<ActionResult<Member>> Insert([FromBody] Member member)
        {
            try
            {
                return Ok(await this._service.Insert(member));
            }
            catch (Exception ex)
            {
                return UnprocessableEntity(ex.GetInnerException());
            }
        }

        [HttpGet("GetByName")]
        public async Task<ActionResult<Member>> GetByName(string name)
        {
            try
            {
                return Ok(await this._service.GetByName(name));
            }
            catch (Exception ex)
            {
                return UnprocessableEntity(ex.GetInnerException());
            }
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<Member>> GetAll()
        {
            try
            {
                return Ok(await this._service.GetAll());
            }
            catch (Exception ex)
            {
                return UnprocessableEntity(ex.GetInnerException());
            }
        }

    }
}