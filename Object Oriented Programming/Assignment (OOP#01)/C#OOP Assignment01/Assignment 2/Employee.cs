using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace C_OOP_Assignment01.Assignment_2
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int securitylevel { get; set; }
        public double salary { get; set; }
        public DateOnly hiredate {get; set;}
        public string gender { get; set; }
        public Employee(int ID,string NAME,int SECURITYLEVEL,double SALARY,DateOnly HIREDATE,string GENDER)
        {
            id = ID;
            name = NAME;
            securitylevel = SECURITYLEVEL;
            salary = SALARY;
            hiredate = HIREDATE;
            gender = GENDER;
        }
        public void printemployee()
        {
            Console.WriteLine($"Employee info: id={id} , name={name} , SecurityLevel={securitylevel} , Salary={salary} , Hire Date={hiredate}, Gender={gender}");
        }

    }
}
