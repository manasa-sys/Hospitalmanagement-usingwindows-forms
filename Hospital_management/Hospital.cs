using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management
{
    public class Hospital
    {
        public Hospital() { }

        Patients mypatients = new Patients();
        Doctors mydoctors = new Doctors();
        Nurses mynurses = new Nurses();

        int i_patient = 0;
        int i_doctor = 0;
        int i_nurse = 0;


        public string addPatient(string pfn, string pln, int departmentCode, string patientId,
            string psn, double balance, string dischargestatus)
        {
            string msg = "";
            if (patientId.Length != 10)
            {
                msg = "Error!id should be exactly 10 characters!";
            }
            else
            {
                if (pfn.Length + pln.Length > 50)
                {
                    msg = "length cannot be more than 50 characters";
                }
                else
                {
                    Patient patient = new Patient(pfn, pln, departmentCode, patientId, psn, balance,
                        dischargestatus);
                    mypatients.add(patient);

                    msg = "patient added successfully";
                    i_patient++;

                }
            }

            return msg;
        }

        public bool patientVerifier(string patientId)
        {
            bool flag = false;
            foreach (Patient patient in mypatients)
            {
                if (patient.getID() == patientId)
                {
                    flag = true;
                }
            }
            return flag;
        }


        public bool doctorVerifier(string dId)
        {
            bool flag = false;
            foreach (Doctor doc in mydoctors)
            {
                if (doc.getID() == dId)
                {
                    flag = true;
                }
            }
            return flag;

        }

        public string addDoctor(string dfn, string dln, int ddeptCode, string dId, int yop, double dshifthours)
        {
            string msg = "";
            if (dId.Length != 10)
            {
                msg = "error!id should be exactly 10 characters";
            }
            else
            {
                if (dfn.Length + dln.Length > 50)
                {
                    msg = "Eroor! name length should not be more than 50";
                }
                else
                {
                    Doctor doctor = new Doctor(dfn, dln, ddeptCode, dId, yop, dshifthours);
                    mydoctors.Add(doctor);
                    msg = "doctor added successfully";
                    i_doctor++;

                }
            }
            return msg;
        }

        public bool nurseVerifier(string nId)
        {
            bool flag = false;
            foreach (Nurse nur in mynurses)
            {
                if (nur.getID() == nId)
                {
                    flag = true;
                }
            }
            return flag;

        }

        public string addNurse(string nfn, string nln, int ndeptCode, string nId, int yop, int nsh, int noofPatients)
        {
            string msg = "";
            if (nId.Length != 10)
            {
                msg = "error! length cannot be more than 10";
            }
            else
            {
                if (nfn.Length + nln.Length > 50)
                {
                    msg = "error! length of the name cannot be more than 50";
                }
                else
                {
                    Nurse nurse = new Nurse(nfn, nln, ndeptCode, nId, yop, nsh, noofPatients);
                    mynurses.add(nurse);
                    msg = "nurse added successfully";
                    i_nurse++;

                }
            }
            return msg;
        }

        public double addBalancetoPatientAccount(double amount, string pId)
        {
            double totBalance = 0.0;

            foreach (Patient patient in mypatients)
            {
                if (patient.getID() == pId)
                {
                    //patient.Balance += amount;
                    totBalance = patient.Balance + amount;
                }

            }

            return totBalance;
        }

        public double deductBalancetoPatientAccount(double amount, string pId)
        {
            double totBalance = 0.0;

            foreach (Patient patient in mypatients)
            {
                if (patient.getID() == pId)
                {
                    //patient.Balance += amount;
                    totBalance = patient.Balance - amount;
                }

            }

            return totBalance;
        }

        public string getAllPatientInfo()
        {
            string info = "";
            foreach (Patient pt in mypatients)
            {
                info += pt.toString();
                info += Environment.NewLine;
            }
            return info;
        }
        public string getAllDoctorInfo()
        {
            string info = "";
            foreach (Doctor d in mydoctors)
            {
                info += d.toString();
                info += Environment.NewLine;
            }
            return info;
        }
        public string getAllNurseInfo()
        {
            string info = "";
            foreach (Nurse d in mynurses)
            {
                info += d.toString();
                info += Environment.NewLine;
            }
            return info;
        }


    }
}

