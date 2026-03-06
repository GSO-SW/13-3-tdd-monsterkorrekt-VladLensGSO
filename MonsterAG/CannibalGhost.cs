using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterAG
{
    public class CannibalGhost : Ghost
    {
        public CannibalGhost(string name) : base(name)
        {
        }

        public void Eat(Ghost ghostToEat)
        {
            if (ghostToEat == null)
            {
                throw new ArgumentNullException(nameof(ghostToEat), "Der Geist, den der Kannibale essen möchte, darf nicht null sein.");
            }
            else
            {
                size += ghostToEat.Size;
                ghostToEat.Size = 0;
            }
                
        }
    }
}
