using System.Collections.Generic;
using CommanderAPI.Models;

namespace CommanderAPI.Infra.Repositories
{
  public class MockRepository : ICommandRepository
  {
    public IEnumerable<Command> GetAllCommands()
    {
      var commands = new List<Command>
      {
        new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"},
        new Command{Id=1, HowTo="Cut bread", Line="Get knife", Platform="Knife and chopping board"},
        new Command{Id=2, HowTo="Make cup of tea", Line="Place teabag in cup", Platform="Kettle & Cup"},
      };

      return commands;      
    }

    public Command GetCommandById(int id)
    {
      return new Command{Id=id, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"};
    }
  }
}