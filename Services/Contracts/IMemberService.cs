using System.Threading.Tasks;
using SquadRegisterApi.Models;

namespace SquadRegisterApi.Services.Contracts
{
    public interface IMemberService
    {
         Task<Member> Insert(Member member);
         
    }
}