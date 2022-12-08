using PCL.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL.Abstraction.Models
{
    public interface IInstagramData
    {
        List<Account> GetAccounts();
    }
}
