using System.Collections.Generic;
using System.Threading.Tasks;
using SquadRegisterApi.Models;

namespace SquadRegisterApi.Services.Contracts
{
  public interface IMemberService
  {
    Task<Member> Insert(Member member);
    Task<List<Member>> GetBySquad(int squad_id);
    Task<List<Member>> GetAll();
    Task<Member> Update(Member member);
    Task<Member> Delete(int id);
  }
}