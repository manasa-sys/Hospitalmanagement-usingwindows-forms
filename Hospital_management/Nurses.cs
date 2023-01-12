using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management
{
    class Nurses : CollectionBase
    {
        public void add(Nurse nur)
        {
            List.Add(nur);
        }
        public Nurse this[int index]
        {
            get { return (Nurse)this[index]; }
            set { List[index] = value; }
        }
    }

}
