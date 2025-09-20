namespace Schedule.DTO
{
    public class ScheduleDayRoomTimeDTO
    {
        public int SDRT_ID { get; set; }
        public int ScheduleID { get; set; }
        public string DayOfWeek { get; set; }
        public string Room { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
