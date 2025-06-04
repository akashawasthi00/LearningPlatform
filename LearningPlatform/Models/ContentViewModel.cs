using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningPlatform.Models
{
	public class ContentViewModel
	{
        public int ContentId { get; set; }
        public string ContentType { get; set; }
        public string ContentBody { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}