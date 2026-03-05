using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_OOP_Assignment01.Assignment_2
{
    #region Encapsulation (4) Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
    enum Previliges { Guest, Developer, Secretary, DBA,SecurityOfficer }
    #endregion
    class Hiringdate
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public Hiringdate (int DAY, int MONTH,int YEAR) 
        {
            day = DAY;
            month= MONTH;
            year = YEAR;
        }
        //public void printhiredate()
        //{
        //    Console.WriteLine( "day,month,year");
        //    Console.WriteLine($"{day} , {month} , {year}");
        //}
        public override string ToString()
        {
            return $"{string.Format("Hiringdate:{0:D2}/{1:D2}/{2}",day,month,year)}";
        }
    }

    class Employeee
    {
        public int id { get; set; }
        public string name { get; set; }
        public Previliges securitylevel { get; set; }
        public double salary { get; set; }
        public Hiringdate hiredate { get; set; }
        private char gender;
        public char Gender
        {
            get { return gender; }
           
            set
            {
                    if (value == 'M' || value == 'F')
                    {
                        gender = value;
                    }
                    else { throw new ArgumentException ( "The gender must be 'M' or 'F'" ); }
            }
        }
        public Employeee(int ID, string NAME, Previliges SECURITYLEVEL, double SALARY, Hiringdate HIREDATE, char GENDER)
        {
            id = ID;
            name = NAME;
            securitylevel = SECURITYLEVEL;
            hiredate = HIREDATE;
            salary = SALARY;
            Gender = GENDER;
        }
        //public void printemployeee()
        //{
        //    Console.WriteLine($"Employee info: id={id} , name={name} , SecurityLevel={securitylevel} , Salary={salary} , Hire Date={hiredate}, Gender={Gender}");
        //    hiredate.printhiredate();

        //}
        public override string ToString()
        {
            return $"Employee info: id={id} , name={name} , SecurityLevel={securitylevel} , {string.Format("Salary={0:C}",salary)} , {hiredate.ToString()}, Gender={Gender}";
        }


    }
}
