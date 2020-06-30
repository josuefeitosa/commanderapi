using AutoMapper;
using CommanderAPI.Models;
using CommanderAPI.DTOs;

namespace CommanderAPI.Profiles
{
  public class CommandsProfile : Profile
  {
    public CommandsProfile()
    {
      CreateMap<Command, CommandReadDTO>();
    }
  }
}