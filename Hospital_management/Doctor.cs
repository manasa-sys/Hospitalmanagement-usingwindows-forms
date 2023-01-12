using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management
{
    class Doctor : Person
    {
        string doctorId;
        int yearsOfPractice;
        double shiftHours;

        public Doctor(string firstname, string lastname, int departmentCode, string dId, int yOP, double shifthours) : base(firstname, lastname, departmentCode)
        {
            this.doctorId = dId;
            this.yearsOfPractice = yOP;
            this.shiftHours = shifthours;
        }

        public string DoctorId
        {
            get { return doctorId; }
            set { doctorId = value; }
        }

        public int YearsOfPractice
        {
            get { return yearsOfPractice; }
            set { yearsOfPractice = value; }
        }

        public double ShiftHours
        {
            get { return shiftHours; }
            set
            {
                shiftHours = value;
            }
        }

        public override string toString()
        {
            return base.toString() + this.DoctorId + this.yearsOfPractice + this.shiftHours;
        }

        public string getID()
        {
            return this.doctorId;
        }

        public int getyearsOfexperince()
        {
            return this.yearsOfPractice;
        }
        public double getShiftHours()
        {
            return this.shiftHours;
        }


    }
}
