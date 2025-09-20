using AutoMapper;
using Schedule.DTO;
using Schedule.Models;

namespace Schedule.MAPPING
{
    public class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            CreateMap<Subject, SubjectDTO>();
            CreateMap<SubjectDTO, Subject>();
        }
    }
}
