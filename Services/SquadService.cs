using System;
using System.ComponentModel.DataAnnotations;
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
                if (string.IsNullOrEmpty(squad.name))
                    throw new ValidationException("The name property cannot be null or empty");
                    
                if (string.IsNullOrEmpty(squad.description))
                    throw new ValidationException("The description property cannot be null or empty");

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