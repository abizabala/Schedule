namespace Schedule.DTO
{
    public class SchedulesDTO
    {
        public int ScheduleID { get; set; }
        public int SectionID { get; set; }
        public int SubjectID { get; set; }
        public string InstructorName { get; set; }
        public bool? isDeleted { get; set; }
    }
}
