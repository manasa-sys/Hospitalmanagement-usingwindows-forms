using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management
{
    class Nurse : Person
    {
        string nurseId;
        int yearsOfPractice;
        double shiftHours;
        int numberOfPatients;

        public Nurse(string firstname, string lastname, int departmentCode, string nurseId, int yearsOfPractice, double shiftHours, int numberOfPatients) : base(firstname, lastname, departmentCode)
        {
            this.nurseId = nurseId;
            this.yearsOfPractice = yearsOfPractice;
            this.shiftHours = shiftHours;
            this.numberOfPatients = numberOfPatients;
        }

        public string NurseId
        {
            get { return nurseId; }
            set { nurseId = value; }
        }

        public int YearsOfPractice
        {
            get { return yearsOfPractice; }
            set { yearsOfPractice = value; }
        }

        public double ShiftHours
        {
            get { return shiftHours; }
            set { shiftHours = value; }
        }

        public int NumberOfPatients
        {
            get { return numberOfPatients; }
            set
            {
                numberOfPatients = value;
            }
        }
        public override string toString()
        {
            return base.toString() + this.nurseId + this.yearsOfPractice + this.shiftHours + this.numberOfPatients;
        }

        public string getID()
        {
            return this.nurseId;
        }
        public int getyearsOfPractice()
        {
            return this.yearsOfPractice;
        }

        public double getshiftHours()
        {
            return this.shiftHours;
        }
    }
}
