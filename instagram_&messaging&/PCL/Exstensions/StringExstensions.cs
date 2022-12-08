using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL.Exstensions
{
    public static class StringExstensions
    {
        public static bool IsNothing(this string str)
        {
            bool Boolean1 = String.IsNullOrEmpty(str);
            bool Boolean2 = String.IsNullOrWhiteSpace(str);
            if (Boolean1 == false && Boolean2 == false)
                return false;
            else
                return true;
        }
    }
}
