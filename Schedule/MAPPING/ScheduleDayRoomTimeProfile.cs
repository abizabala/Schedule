using AutoMapper;
using Schedule.Models;

namespace Schedule.MAPPING
{
    public class ScheduleDayRoomTimeProfile : Profile
    {
        public ScheduleDayRoomTimeProfile()
        {
            CreateMap<ScheduleDayRoomTime, ScheduleDayRoomTimeDto>();
            CreateMap<ScheduleDayRoomTimeDto, ScheduleDayRoomTime>();
        }
    }
}
