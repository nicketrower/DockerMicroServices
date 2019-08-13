using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.API.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FriendList, FriendListDto>();
            CreateMap<FriendListDto, FriendList>();
        }
    }
}
