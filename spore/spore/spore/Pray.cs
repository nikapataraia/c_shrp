using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spore
{
    internal class Pray : Entity
    {
        public Pray() : base(new Random().Next(1, 101))
        {

        }   
    }
}
