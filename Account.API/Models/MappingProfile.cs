using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.API.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AccountInfo, AccountInfoDto>();
            CreateMap<AccountInfoDto, AccountInfo>();
        }
    }
}
