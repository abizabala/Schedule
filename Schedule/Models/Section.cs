namespace Schedule.Models
{
    public class Section
    {
        public int SubjectID { get; set; }
        public string SectionName { get; set; }
        public int YearLevel { get; set; }
        public bool? isDeleted { get; set; }
    }
}
