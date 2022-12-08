using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL.Abstraction.Models
{
    public interface IPerson
    {
        string FullName { get; set; }
        int Age { get; set; }
        GenderType Gender { get; set; }
        string MobileNumber { get; set; }
    }
}
