using Microsoft.EntityFrameworkCore;
using Template.Models;

namespace Template.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
        }
        public DbSet<Command> Commands { get; set; }

    }
}
