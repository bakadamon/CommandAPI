using Microsoft.EntityFrameworkCore;

namespace CommandAPI.Models
{
    public class CommandContext : DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options) : base(options)
        {

        }

        public DbSet<Command> CommandItems {get; set;}
    }

}
// git add .
// git commit -m “{title}”
// git push origin master