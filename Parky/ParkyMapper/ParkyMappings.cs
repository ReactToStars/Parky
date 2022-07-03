using AutoMapper;
using Parky.Models;
using Parky.Models.DTOs;

namespace Parky.ParkyMapper
{
    public class ParkyMappings : Profile
    {
        public ParkyMappings()
        {
            CreateMap<NationalPark, NationalParkDTO>().ReverseMap();
            CreateMap<Trail, TrailDTO>().ReverseMap();
            CreateMap<Trail, TrailUpsertDTO>().ReverseMap();
        }
    }
}
