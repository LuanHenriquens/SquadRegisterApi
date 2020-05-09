using System.Collections.Generic;
using System.Threading.Tasks;
using SquadRegisterApi.Models;

namespace SquadRegisterApi.Services.Contracts
{
    public interface ISquadService
    {
         Task<Squad> Insert(Squad squad);
         Task<List<Squad>> GetByName(string name);
         Task<List<Squad>> GetAll();
         Task<Squad> Update(Squad squad);
    }
}