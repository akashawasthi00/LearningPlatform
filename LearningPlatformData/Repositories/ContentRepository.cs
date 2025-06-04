using LearningPlatformData.DBML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatformData
{
    public class ContentRepository : IContentRepository
    {
        private readonly LearningDataClassesDataContext _context;

        public ContentRepository(LearningDataClassesDataContext context)
        {
            _context = context;
        }

        public IEnumerable<proc_GetContentByTopicIdResult> GetContentByTopicId(int topicId)
        {
            return _context.proc_GetContentByTopicId(topicId).ToList();
        }

        public content GetContentById(int contentId)
        {
            return _context.contents.FirstOrDefault(c => c.content_id == contentId);
        }

    }
}