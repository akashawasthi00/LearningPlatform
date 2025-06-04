using LearningPlatformData.DBML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatformData
{
   public interface ITopicRepository
    {
        List<proc_GetTopicsByCourseResult> GetTopicsByCourse(string courseName);
        topic GetTopicById(int topicId);
    }
}
