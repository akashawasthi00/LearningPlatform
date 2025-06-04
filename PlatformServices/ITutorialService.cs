using LearningPlatformData.DBML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformServices
{
    public interface ITutorialService
    {
        IEnumerable<proc_GetContentByTopicIdResult> GetContentByTopicId(int topicId);
        IEnumerable<proc_GetTopicsByCourseResult> GetTopicsByCourse(string courseName);
        IEnumerable<Media> GetMedias();
        void AddMedia(Media media);
    }
}