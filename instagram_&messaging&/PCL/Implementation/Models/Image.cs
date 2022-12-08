using PCL.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL.Implementation.Models
{
    public class Image
    {
        public static int ID { get; set; } = 0;
        public string ImageUrl { get; set; }
        public List<string> Likes { get; set; } = new List<string>();
        public Image()
        {
            ID++;
        }
        public int GetID()
        {
            return ID;
        }
    }
}
