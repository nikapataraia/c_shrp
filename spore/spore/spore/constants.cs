using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spore
{
    static class constants
    {
        public static List<evolution_ability> abilities = new List<evolution_ability> {
            new mobilityevolution_ability { name = "body" , count = 0, stamina_cost = 1 , stamina_requirment = 0, speed = 1 },
            new mobilityevolution_ability { name = "foot" , count = 1, stamina_cost = 2 , stamina_requirment = 20, speed = 3 },
            new mobilityevolution_ability {name = "foot" , count = 2, stamina_requirment = 40, stamina_cost = 2, speed = 4},
            new mobilityevolution_ability {name = "foot" , count = 2, speed = 6, stamina_cost = 4, stamina_requirment = 60},
            new mobilityevolution_ability {name = "wing" , count = 2, speed = 8, stamina_cost = 4, stamina_requirment = 80},
            new attackevolution_mult_ability {name = "claw" , count = 1, improvement = 2},
            new attackevolution_mult_ability {name = "claw" , count = 2, improvement = 3},
            new attackevolution_mult_ability {name = "claw" , count = 3, improvement = 4},
            new attackevolution_add_ability {name = "teeth" , count = 1, improvement = 3},
            new attackevolution_add_ability {name = "teeth" , count = 2, improvement = 6},
            new attackevolution_add_ability {name = "teeth" , count = 3, improvement = 9},


        };
    }
}
