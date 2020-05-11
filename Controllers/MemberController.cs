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

    [HttpGet("GetBySquad")]
    public async Task<ActionResult<Member>> GetBySquad(int squad_id)
    {
      try
      {
        return Ok(await this._service.GetBySquad(squad_id));
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

    [HttpPut]
    public async Task<ActionResult<Member>> Update([FromBody] Member member)
    {
      try
      {
        return Ok(await this._service.Update(member));
      }
      catch (Exception ex)
      {
        return UnprocessableEntity(ex.GetInnerException());
      }
    }

    [HttpDelete]
    public async Task<ActionResult<Member>> Delete(int id)
    {
      try
      {
        return Ok(await this._service.Delete(id));
      }
      catch (Exception ex)
      {
        return UnprocessableEntity(ex.GetInnerException());
      }
    }
  }
}