using LearningPlatformData.DBML;
using LearningPlatformData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatformServices
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public List<course> GetAllCourses()
        {
            return _courseRepository.GetAllCourses();
        }

        public course GetCourseByName(string courseName)
        {
            return _courseRepository.GetCourseByName(courseName);
        }
    }
}
