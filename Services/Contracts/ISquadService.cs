using System.Threading.Tasks;
using SquadRegisterApi.Models;

namespace SquadRegisterApi.Services.Contracts
{
    public interface ISquadService
    {
         Task<Squad> Insert(Squad squad);
    }
}