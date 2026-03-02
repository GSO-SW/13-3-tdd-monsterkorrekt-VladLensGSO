using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterAG
{
    public class Ghost
    {
        protected string name;
        protected int size;


        public Ghost(string name)
        {
            this.name = name;
            this.size = 1;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Size
        {
            get
            {
               return size;
            }
            set
            {
               size = value;
            }
        }

        public virtual string Haunt()
        {
            return name + "sagt: 'Buh'";
        }
    }
}
