using PCL.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL.Implementation.Models
{
    public class Person : IPerson
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }
        public string MobileNumber { get; set; }
    }
}
