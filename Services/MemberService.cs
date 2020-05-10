using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SquadRegisterApi.Auxiliar;
using SquadRegisterApi.Data;
using SquadRegisterApi.Models;
using SquadRegisterApi.Services.Contracts;

namespace SquadRegisterApi.Services
{
    public class MemberService : IMemberService
    {
        private Context _context;
        public MemberService(Context _context)
        {
            this._context = _context;
        }

        public async Task<Member> Insert(Member member)
        {
            try
            {
                if (string.IsNullOrEmpty(member.name))
                    throw new ValidationException("The name property cannot be null or empty");

                if (string.IsNullOrEmpty(member.function))
                    throw new ValidationException("The function property cannot be null or empty");

                if(string.IsNullOrEmpty(member.squad_id.ToString()) || member.squad_id <= 0)
                    throw new ValidationException("The squad_id property cannot be null, empty or 0.");
                
                var squad = await this._context.Squad.FirstOrDefaultAsync(c => c.id == member.squad_id);

                if(squad == null)
                    throw new ValidationException("Invalid squad.");

                member.create_date = DateTime.Now;

                await this._context.Member.AddAsync(member);
                await this._context.SaveChangesAsync();

                return member;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.GetInnerException());
            }
        }
    }
}