using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spore
{
    internal class evolution
    {
        private int count { get; set; }
        public evolution()
        {
            count = 0;
        }
        public int getcount()
        {
            return count;
        }
        public void evolve()
        {
            count++;
        }
    }

    internal class attackevolution : evolution
    {
    }

    internal class mobilityevolution : evolution
    {
    }
    class leg : mobilityevolution
    {
    }
    class wing : mobilityevolution
    {

    }
    class claw : attackevolution
    {

    }
    class teeth : attackevolution
    {

    }
}
