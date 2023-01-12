using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management
{
    class Patients : CollectionBase
    {
        public void add(Patient pat)
        {
            List.Add(pat);
        }

        public Patient this[int index]
        {
            get { return (Patient)List[index]; }
            set { List[index] = value; }

        }


    }
}
