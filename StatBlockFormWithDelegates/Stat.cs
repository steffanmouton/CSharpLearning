using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatBlockFormWithDelegates
{
    public delegate void ValueChangedEvent(Stat stat);
    public class Stat
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public ValueChangedEvent onValueChanged;

    }
}
