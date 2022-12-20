using AutoMapper;
using fjorubordid_database.Data;
using fjorubordid_database.Models;
using System.Diagnostics.Metrics;

namespace fjorubordid_database.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            
            CreateMap<ApiUser, ApiUserDto>().ReverseMap();
        }
    }
}
