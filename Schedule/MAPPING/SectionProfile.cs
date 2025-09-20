using AutoMapper;
using Schedule.DTO;
using Schedule.Models;

namespace Schedule.MAPPING
{
    public class SectionProfile : Profile
    {
        public SectionProfile()
        {
            CreateMap<Section, SectionDTO>();
            CreateMap<SectionDTO, Section>();
        }
    }
}
