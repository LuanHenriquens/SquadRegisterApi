using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Squad>> GetByName(string name)
        {
            try
            {
                if (name == null)
                    throw new ValidationException("The name property cannot be null.");

                return await this._context.Squad.Where(c => c.name.Contains(name)).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.GetInnerException());
            }
        }

        public async Task<List<Squad>> GetAll()
        {
            try
            {
                return await this._context.Squad.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.GetInnerException());
            }
        }

        public async Task<Squad> Update(Squad squad)
        {
            try
            {

                if (squad == null)
                    throw new ValidationException("The squad object cannot be null.");

                if (string.IsNullOrEmpty(squad.name))
                    throw new ValidationException("The name property cannot be null or empty.");

                if (string.IsNullOrEmpty(squad.create_date.ToString()))
                    throw new ValidationException("The create_data property cannot be null or empty.");

                if (string.IsNullOrEmpty(squad.description))
                    throw new ValidationException("The description property cannot be null or empty.");


                this._context.Squad.Update(squad);
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