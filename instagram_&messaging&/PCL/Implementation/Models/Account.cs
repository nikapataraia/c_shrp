using PCL.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL.Implementation.Models
{
    public class Account : IAccount
    {
        public static int ID = 0;
        public string Password { get; set; }
        public string UserName { get; set; }
        public Person person { get; set; }
        public List<FollowClass> Followers { get; set; } = new List<FollowClass>();
        public List<FollowClass> Following { get; set; } = new List<FollowClass>();
        public List<Image> images { get; set; } = new List<Image>();
        public List<Message> SentMessages { get; set; } = new List<Message>();
        public List<Message> RecievedMessages { get; set; } = new List<Message>();
        public List<Post> posts { get; set; } = new List<Post>();
        public string ProfilePictureUrl { get; set; }
        public List<Post> LikedPosts { get; set; } = new List<Post>();
        public Account()
        {
            ID++;
        }
    }
}
