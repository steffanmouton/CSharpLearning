using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCasting
{
    class Zombie : Entity
    {
        public void Print()
        {
            Debug.WriteLine(null);
            Debug.WriteLine(Name);
            Debug.WriteLine(Hungry);
        }

        public bool Hungry { get; set; }

        public Zombie()
        {
            Hungry = true;
        }
    }
}
