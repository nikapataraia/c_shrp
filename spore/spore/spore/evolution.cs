using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spore
{
    internal class evolution_ability
    { 
        public string name;
        public int count;
    }

    internal class attackevolution : evolution_ability
    {
        public int improvement;
    }
    internal class attackevolution_mult_ability : attackevolution 
    {
    }

    internal class attackevolution_add_ability : attackevolution 
    {
    }



    internal class mobilityevolution_ability : evolution_ability
    {
        public int stamina_cost;
        public int stamina_requirment;
        public int speed;
    }
}
