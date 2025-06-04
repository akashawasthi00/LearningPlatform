using LearningPlatformData.DBML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatformData
{
    public class TopicRepository : ITopicRepository
    {
        private readonly LearningDataClassesDataContext _context;

        public TopicRepository(LearningDataClassesDataContext context)
        {
            _context = context;
        }

        public List<proc_GetTopicsByCourseResult> GetTopicsByCourse(string courseName)
        {
            return _context.proc_GetTopicsByCourse(courseName).ToList();
        }

        public topic GetTopicById(int topicId)
        {
            return _context.topics.SingleOrDefault(t => t.topic_id == topicId);
        }
    }
}