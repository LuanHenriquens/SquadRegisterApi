using Microsoft.EntityFrameworkCore;
using SquadRegisterApi.Models;

namespace SquadRegisterApi.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options){}

        public DbSet<Squad> Squad {get; set;}
    }
}