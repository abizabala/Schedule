using AutoMapper;
using Schedule.DTO;
using Schedule.Models;

namespace Schedule.MAPPING
{
    public class ScheduleProfile : Profile
    {
        public ScheduleProfile()
        {
            CreateMap<Schedules, SchedulesDTO>();
            CreateMap<SchedulesDTO, Schedules>();
        }
    }
}
