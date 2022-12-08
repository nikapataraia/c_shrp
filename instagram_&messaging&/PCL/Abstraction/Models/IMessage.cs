using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL.Abstraction.Models
{
    public interface IMessage
    {
        string message { get; set; }
        string Sender { get; set; }
        string Reciever { get; set; }
        DateTime Time { get; set; }
    }
}
