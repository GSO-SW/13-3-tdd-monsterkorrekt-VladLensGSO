using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterAG
{
    public class SlimeGhost : Ghost
    {
        public SlimeGhost(string name) : base(name)
        {
        }
        public string Slime()
        {
            return $"{Name} hinterlässt eine Schleimspur.";
        }
        public override string Haunt()
        {
            return $"{Slime()}\r\n{Name} sagt: 'Buh'";
        }
    }
}
