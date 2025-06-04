using LearningPlatformData.DBML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatformData
{
    public class CourseRepository : ICourseRepository
    {
        private readonly LearningDataClassesDataContext _context;

        public CourseRepository(LearningDataClassesDataContext context)
        {
            _context = context;
        }

        public IEnumerable<course> GetAllCourses()
        {
            return _context.courses.ToList();
        }

        public course GetCourseByName(string courseName)
        {
            return _context.courses.FirstOrDefault(c => c.course_name == courseName);
        }
    }
}