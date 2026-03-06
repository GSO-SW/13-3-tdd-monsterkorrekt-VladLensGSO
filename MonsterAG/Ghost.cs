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
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Der Name eines Geistes darf nicht leer oder nur aus Leerzeichen bestehen.");
            }
            else
            {
                this.name = name;
                this.size = 1;
            }
                
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
                if (value < 0)
                {
                    size = 0;
                }
                else
                {
                    size = value;
                }
                    
            }
        }

        public virtual string Haunt()
        {
            return name + " sagt: 'Buh'";
        }
    }
}
