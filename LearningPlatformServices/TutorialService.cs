using LearningPlatformData.DBML;
using LearningPlatformData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatformServices
{
    public class TutorialService : ITutorialService
    {
        private readonly ITopicRepository _topicRepository;
        private readonly IContentRepository _contentRepository;
        private readonly ICourseRepository _courseRepository;

        public TutorialService(ITopicRepository topicRepository, IContentRepository contentRepository, ICourseRepository courseRepository)
        {
            _topicRepository = topicRepository;
            _contentRepository = contentRepository;
            _courseRepository = courseRepository;
        }

        public List<proc_GetTopicsByCourseResult> GetTopicsByCourse(string courseName)
        {
            return _topicRepository.GetTopicsByCourse(courseName)
                .OrderBy(t => _topicRepository.GetTopicById(t.topic_id)?.topic_order ?? int.MaxValue)
                .ToList();
        }

        public List<proc_GetContentByTopicIdResult> GetContentByTopicId(int topicId)
        {
            return _contentRepository.GetContentByTopicId(topicId);
        }

        public topic GetTopicById(int topicId)
        {
            return _topicRepository.GetTopicById(topicId);
        }

        public string GetCourseNameByTopicId(int topicId)
        {
            var topic = _topicRepository.GetTopicById(topicId);
            if (topic == null) return "Linux";
            var course = _courseRepository.GetAllCourses()
                .FirstOrDefault(c => c.course_id == topic.course_id);
            return course?.course_name ?? "Linux";
        }
    }
}