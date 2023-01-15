using AnonTalk.DTO;
using AnonTalk.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonTalk.Profiles
{
    public class PostLimitedProfile : Profile
    {
        public PostLimitedProfile()
        {
            CreateMap<PostLimitedReceiveDTO, PostLimited>();
        }
    }
}
