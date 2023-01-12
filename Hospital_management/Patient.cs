using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management
{
    class Patient : Person
    {
        string patientId;
        string sectionNumber;
        double balance;
        string dischargeStatus;

        public Patient(string firstname, string lastname, int departmentCode, string patientId, string sectionNumber, double balance, string dischargeStatus) : base(firstname, lastname, departmentCode)
        {
            this.patientId = patientId;
            this.sectionNumber = sectionNumber;
            this.balance = balance;
            this.dischargeStatus = dischargeStatus;
        }

        public string PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }

        public string SectionNumber
        {
            get { return sectionNumber; }
            set { sectionNumber = value; }
        }
        public double Balance
        {
            get { return balance; }
            set
            {
                balance = value;
            }
        }
        public string DischargeStatus
        {
            get { return dischargeStatus; }
            set { dischargeStatus = value; }
        }

        public override string toString()
        {
            return base.toString() + this.patientId + " " + this.sectionNumber + " " + this.balance + " " + this.dischargeStatus;
        }

        public string getID()
        {
            return this.patientId;
        }
        public string getSectionNumber()
        {
            return this.sectionNumber;
        }

        public double getBalance()
        {
            return this.balance;
        }
    }
}
