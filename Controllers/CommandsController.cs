using System.Collections.Generic;
using AutoMapper;
using CommanderAPI.DTOs;
using CommanderAPI.Infra.Repositories;
using CommanderAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommanderAPI.Controllers
{
  [Route("api/commands")] //Opcionally use "api/[controller]" to follow the controller's name
  [ApiController]
  public class CommandsController: ControllerBase  //use Controller for MVC with Views, in this case, is MVC without Views
  {
    // private readonly CommandRepository _repository = new CommandRepository();
    private readonly ICommandRepository _repository;
    private readonly IMapper _mapper;

    public CommandsController(ICommandRepository repository, IMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }

    //GET api/commands
    [HttpGet] 
    public ActionResult <IEnumerable<CommandReadDTO>> GetAllCommands()
    {
      var commandItems = _repository.GetAllCommands();

      return Ok(_mapper.Map<IEnumerable<CommandReadDTO>>(commandItems));
    }

    //GET api/commands/{id}
    [HttpGet("{id}")]
    public ActionResult <CommandReadDTO> GetCommandById(int id)
    {
      var commandItem = _repository.GetCommandById(id);

      if (commandItem != null)
      {
        return Ok(_mapper.Map<CommandReadDTO>(commandItem));
      }

      return NotFound();
    }
  }
}