using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL.Implementation.Models
{
    public class Post
    {
        public string ProfilePictureURL { get; set; }
        public string Text { get; set; }
        public string ImageURL { get; set; }
        public int Likes { get; set; } = 0;
        public string UploaderUserName { get; set; }
        public List<Comment> comments { get; set; } = new List<Comment>();
        public DateTime Time { get; set; }
    }
}
