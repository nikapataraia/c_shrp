using PCL.Abstraction.Models;
using PCL.Implementation;
using PCL.Implementation.Models;
using PCL.Implementation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram
{
    class Program
    {
        static void Main(string[] args)
        {
            InstagramService instagram = DIContainer.GetInstagramService();
            List<Post> posts = new List<Post>()
            {
                new Post()
                {
                    ImageURL = "Nika",
                    ProfilePictureURL = "nika",
                    Text = "Hello World",
                    Time = DateTime.Now,
                    UploaderUserName = "nikapat"
                }
            };
            var something = posts.FirstOrDefault(o => o.ImageURL == "nika");
            Console.ReadKey();
        }
    }
}
