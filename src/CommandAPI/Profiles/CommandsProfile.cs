using AutoMapper;
using CommandAPI.Dtos;
using CommandAPI.Models;

namespace CommandAPI.Profiles
{
    public class CommandsProfile : Profile

    {
        public CommandsProfile()
        {
            // source -> target
            CreateMap<Command, CommandReadDto>();
        }
    }
}
