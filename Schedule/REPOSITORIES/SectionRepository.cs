using Schedule.REPOSITORIES;
namespace Schedule.Models
{
    public class SectionRepository : IRepository<Section>
    {
        private readonly List<Section> _sections = new();

        public void Add(Section entity)
        {
            _sections.Add(entity);
        }

        public void Delete(Section entity)
        {
            var section = GetById(entity.SubjectID);
            if (section != null)
            {
                section.isDeleted = true;
            }
        }

        public IEnumerable<Section> GetAll()
        {
            return _sections.Where(s => s.isDeleted != true);
        }

        public Section GetById(int id)
        {
            return _sections.FirstOrDefault(s => s.SubjectID == id && s.isDeleted != true);
        }

        public void Update(Section entity)
        {
            var existing = GetById(entity.SubjectID);
            if (existing != null)
            {
                existing.SectionName = entity.SectionName;
                existing.YearLevel = entity.YearLevel;
            }
        }
    }
}
