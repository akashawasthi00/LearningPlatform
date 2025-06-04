using LearningPlatformData.DBML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatformData
{
   public interface IContentRepository
    {
        IEnumerable<proc_GetContentByTopicIdResult> GetContentByTopicId(int topicId);
        content GetContentById(int contentId);
       
    }
}
