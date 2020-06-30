using System.Collections.Generic;
using CommanderAPI.Models;

namespace CommanderAPI.Infra.Repositories
{
  public interface ICommandRepository
  {
    IEnumerable<Command> GetAllCommands();
    Command GetCommandById(int id);
  }
}