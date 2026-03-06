using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterAG
{
    public class CannibalGhost : Ghost
    {
        bool LastGhostWasSlime;
        public CannibalGhost(string name) : base(name)
        {
        }

        public void Eat(Ghost ghostToEat)
        {
            if (ghostToEat == null)
            {
                throw new ArgumentNullException("Der Geist, den der Kannibale essen möchte, darf nicht null sein.");
            }
            else if (ghostToEat == this)
            {
            }
            else if (ghostToEat is SlimeGhost)
            {
                LastGhostWasSlime = true;
                size += ghostToEat.Size;
                ghostToEat.Size = 0;
            }
            else
            {
                LastGhostWasSlime = false;
                size += ghostToEat.Size;
                ghostToEat.Size = 0;
            }

        }

        public override string Haunt()
        {
            if (LastGhostWasSlime)
            {
                return "*Rülps* ...lecker Schleim!" + base.Haunt();
            }
            else
            {
                return base.Haunt();
            }
        }
    }
}
