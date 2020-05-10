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
        public async Task<ActionResult<Member>> Insert(Member member)
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
    }
}