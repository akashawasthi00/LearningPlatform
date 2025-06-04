using LearningPlatformData.DBML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatformData.Repositories
{
    public class MediaRepository : IMediaRepository
    {
        private readonly LearningDataClassesDataContext _context;

        public MediaRepository(LearningDataClassesDataContext context)
        {
            _context = context;
        }

        public IEnumerable<Media> GetMedias()
        {
            return _context.Medias.ToList();
        }

        public void AddMedia(Media media)
        {
            _context.Medias.InsertOnSubmit(media);
            _context.SubmitChanges();
        }
    }
}


