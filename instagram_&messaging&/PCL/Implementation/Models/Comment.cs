using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL.Implementation.Models
{
    public class Comment
    {
        public string text { get; set; }
        public string CommentatorUserName { get; set; }
        public DateTime Time { get; set; } 
    }
}
