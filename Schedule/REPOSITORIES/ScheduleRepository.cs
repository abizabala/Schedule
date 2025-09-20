using Schedule.Models;

namespace Schedule.REPOSITORIES
{
    public class ScheduleRepository : IRepository<Schedules>
    {
        private readonly List<Schedules> _schedules = new();
        public void Add(Schedules entity)
        {
            _schedules.Add(entity);
        }

        public void Delete(Schedules id)
        {
            var schedule = GetById(id.ScheduleID);
            if (schedule != null)
            {
                schedule.isDeleted = true;
            }
        }

        public IEnumerable<Schedules> GetAll()
        {
            return _schedules.Where(s => s.isDeleted != true);
        }

        public Schedules GetById(int id)
        {
            return _schedules.FirstOrDefault(s => s.ScheduleID == id && s.isDeleted != true);
        }

        public void Update(Schedules entity)
        {
            var existing = GetById(entity.ScheduleID);
            if (existing != null)
            {
                existing.SectionID = entity.SectionID;
                existing.SubjectID = entity.SubjectID;
                existing.InstructorName = entity.InstructorName;
            }
        }
    }
}
