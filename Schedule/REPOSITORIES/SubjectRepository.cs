using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Schedule.Models;

namespace Schedule.REPOSITORIES
{
    public class SubjectRepository : IRepository<Subject>

    {
        private readonly List<Subject> _subjects = new();

       
        public void Add(Subject entity)
        {
            _subjects.Add(entity);
        }

        public void Delete(Subject id)
        {
            var subject = GetById(id.SubjectID);
            if (subject != null)
            {
                subject.isDeleted = true;
            }
        }

        public IEnumerable<Subject> GetAll()
        {
            return _subjects.Where(s => s.isDeleted != true);
        }

        public Subject GetById(int id)
        {
            return _subjects.FirstOrDefault(s => s.SubjectID == id && s.isDeleted != true);
        }

        public void Update(Subject entity)
        {
            var existing = GetById(entity.SubjectID);
            if (existing != null)
            {
                existing.SubjectCode = entity.SubjectCode;
                existing.SubjectName = entity.SubjectName;
                existing.Units = entity.Units;
            }
        }
    }
}
