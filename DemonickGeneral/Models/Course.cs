using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemonickGeneral.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PictureLink { get; set; }
        public IEnumerable<Video> CourseVideos { get; set; }

        public virtual Category CategoryId { get; set; }
    }
}
