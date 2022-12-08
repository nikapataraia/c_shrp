using PCL.Implementation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL.Implementation
{
    public static class DIContainer
    {
        public static InstagramService GetInstagramService() => new InstagramService();
    }
}
