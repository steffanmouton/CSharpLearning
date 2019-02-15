using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCasting
{
    class Program
    {
        // The following is a test for casting. Entity is the base class for Zombie and Ninja.
       
        static void Main(string[] args)
        {
            var z = new Zombie();
            var n = new Ninja();
            

            // Zombie, derived class, is cast as object. 
            object zomBox = z;
            var z2 = (Zombie)zomBox;
            
            // n = (Ninja)zombieUnbox;
            // This does not work, trying to convert from Zombie to object, to Ninja throws a "Cannot Cast" error.

            n.Chi = 2;
            // The following is casting from derived (Ninja) to base (Entity)
            Entity e = n;
 
            // n = e;
            // This does not work. To cast a base class to the derived class requires an explicit casting.
            // You also cannot call the derived class functions while in this base class cast. E.g. "e.Chi" is not accessible,
            // as Chi is a member of Ninja, not Entity.

            // The following is allowed. Casting base class Entity to derived Ninja using explicit casting.
            var n2 = (Ninja) e;
            // n2 is declared as a Ninja, assigned e cast as a Ninja. It withheld the Chi value assigned earlier (2), despite not being able to 
            // access it in its Entity form. No data was lost.

            /*
             * -----------------------------------------------------------------------------------------------------------------------------------
             */

            // Write to debugger proving validity:

            var zFirst = new Zombie {Name = "Hungry Zombie"};
            // zFirst Zombie is created, default constructor sets Hungry to true. Name is set to Hungry Zombie.

            zFirst.Print(); // Debug Print Zombie's Name and current Hungry state

            // Zombie eats someone.
            // Change name and Set Hungry state to false, showing that upcoming new zombie is indeed a copy, not a new instance.
            zFirst.Name = "Satiated Zombie";
            zFirst.Hungry = false;
            

            Entity eBase = zFirst; ; // Instance of entity is created for implicit casting
          

            var zSecond = (Zombie) eBase; //Casting eBase as a new zombie. Name should be Satiated Zombie and Hungry = false.
            zSecond.Print();
        }
    }
}