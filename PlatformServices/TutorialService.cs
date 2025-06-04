using LearningPlatformData.DBML;
using LearningPlatformData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningPlatformData.Repositories;

namespace PlatformServices
{
    public class TutorialService : ITutorialService
    {
        private readonly IContentRepository _contentRepository;
        private readonly ITopicRepository _topicRepository;
        private readonly IMediaRepository _mediaRepository;

        public TutorialService(
            IContentRepository contentRepository,
            ITopicRepository topicRepository,
            IMediaRepository mediaRepository)
        {
            _contentRepository = contentRepository;
            _topicRepository = topicRepository;
            _mediaRepository = mediaRepository;
        }

        public IEnumerable<proc_GetContentByTopicIdResult> GetContentByTopicId(int topicId)
        {
            return _contentRepository.GetContentByTopicId(topicId);
        }

        public IEnumerable<proc_GetTopicsByCourseResult> GetTopicsByCourse(string courseName)
        {
            return _topicRepository.GetTopicsByCourse(courseName);
        }

        public IEnumerable<Media> GetMedias()
        {
            return _mediaRepository.GetMedias();
        }

        public void AddMedia(Media media)
        {
            _mediaRepository.AddMedia(media);
        }
    }
}