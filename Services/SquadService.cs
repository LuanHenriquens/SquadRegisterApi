using System;
using System.Threading.Tasks;
using SquadRegisterApi.Auxiliar;
using SquadRegisterApi.Data;
using SquadRegisterApi.Models;
using SquadRegisterApi.Services.Contracts;

namespace SquadRegisterApi.Services
{
    public class SquadService : ISquadService
    {
        private Context _context;
        public SquadService(Context _context)
        {
            this._context = _context;
        }

        public async Task<Squad> Insert(Squad squad)
        {
            try
            {
                squad.create_date = DateTime.Now;

                await this._context.Squad.AddAsync(squad);
                await this._context.SaveChangesAsync();
                return squad;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.GetInnerException());
            }
        }
    }
}