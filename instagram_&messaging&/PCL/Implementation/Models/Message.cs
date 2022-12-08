using PCL.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL.Implementation.Models
{
    public class Message : IMessage
    {
        public string message { get; set; }
        public string Sender { get; set; }
        public string Reciever { get; set; }
        public DateTime Time { get; set; }
    }
}
