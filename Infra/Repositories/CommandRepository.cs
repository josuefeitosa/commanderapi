using System.Collections.Generic;
using System.Linq;
using CommanderAPI.Models;

namespace CommanderAPI.Infra.Repositories
{
  public class CommandRepository : ICommandRepository
  {
    private readonly CommanderContext _context;

    public CommandRepository(CommanderContext context)
    {
        _context = context;
    }
    public IEnumerable<Command> GetAllCommands()
    {
      return _context.Commands.ToList();     
    }

    public Command GetCommandById(int id)
    {
      return _context.Commands.FirstOrDefault(p => p.Id == id);
    }
  }
}