using CommanderAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CommanderAPI.Infra
{
  public class CommanderContext: DbContext
  {
    public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
    {}

    public DbSet<Command> Commands { get; set; }
  }
}