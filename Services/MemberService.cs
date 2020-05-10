using System;
using System.Threading.Tasks;
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