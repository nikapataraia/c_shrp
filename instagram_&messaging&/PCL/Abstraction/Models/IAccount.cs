using PCL.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL.Abstraction.Models
{
    public interface IAccount
    {
        string UserName { get; set; }
        string Password { get; set; }
        Person person { get; set; }
        List<FollowClass> Followers { get; set; }
        List<FollowClass> Following { get; set; }
        List<Image> images { get; set; }
        List<Message> SentMessages { get; set; }
        List<Message> RecievedMessages { get; set; }
        List<Post> posts { get; set; }
    }
}
