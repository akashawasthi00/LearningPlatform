using LearningPlatformData.DBML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatformServices
{
   public interface ITutorialService
    {
        List<proc_GetTopicsByCourseResult> GetTopicsByCourse(string courseName);
        List<proc_GetContentByTopicIdResult> GetContentByTopicId(int topicId);
        topic GetTopicById(int topicId);
        string GetCourseNameByTopicId(int topicId);
    }
}
