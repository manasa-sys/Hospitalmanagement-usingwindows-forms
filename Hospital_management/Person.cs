using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management
{
    abstract class Person
    {
        string firstname;
        string lastname;
        int deptcode;

        public Person(string firstname, string lastname, int deptcode)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.deptcode = deptcode;
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }

        }

        public int DeptCode
        {
            get { return deptcode; }
            set { deptcode = value; }

        }

        public virtual string toString()
        {
            return this.firstname + this.lastname + this.deptcode;
        }
    }
}
