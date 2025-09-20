namespace Schedule.Models
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int Units { get; set; }
        public bool? isDeleted { get; set; }
    }
}
