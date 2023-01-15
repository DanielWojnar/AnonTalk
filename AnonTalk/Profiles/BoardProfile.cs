using AnonTalk.DTO;
using AnonTalk.Models;
using AutoMapper;

namespace AnonTalk.Profiles
{
    public class BoardProfile : Profile
    {
        public BoardProfile()
        {
            CreateMap<BoardReceiveDTO, Board>();
        }
    }
}
