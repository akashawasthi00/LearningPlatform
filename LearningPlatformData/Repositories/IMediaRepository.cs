using LearningPlatformData.DBML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatformData.Repositories
{
    public interface IMediaRepository
    {
        IEnumerable<Media> GetMedias();
        void AddMedia(Media media);
    }
}
