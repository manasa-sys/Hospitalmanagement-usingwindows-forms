using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management
{
    class Doctors : CollectionBase
    {
        public void Add(Doctor doc)
        {
            List.Add(doc);
        }


        public Doctor this[int index]
        {
            get { return (Doctor)List[index]; }
            set { List[index] = value; }
        }
    }
}
