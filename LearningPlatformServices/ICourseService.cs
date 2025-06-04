using LearningPlatformData.DBML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatformServices
{
  public interface ICourseService
    {
        List<course> GetAllCourses();
        course GetCourseByName(string courseName);
    }
}
