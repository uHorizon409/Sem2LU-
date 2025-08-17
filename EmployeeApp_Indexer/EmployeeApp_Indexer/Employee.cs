using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp_Indexer
{
    class Employee
    {
        //declaring attributes
        double salary;
        string empNumber, jobTitle, name, surname;

        // declaring properties
        
        public string Name 
        {
            get 
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        public string EmpNumber
        {
            get
            {
                return empNumber;
            }
            set
            {
                this.empNumber = value;
            }
        }
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                this.jobTitle = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                this.surname = value;
            }
        }
        public double Salary
            {
            get 
            { 
                return this.salary;

            }
            set
            {
                this.salary = value;
            } 
            }
        public Employee(string empnum, string title, string nme, string snme, double sal) 
        {
            this.empNumber = empnum;
            this.jobTitle = title;
            this.name = nme;
            this.surname = snme;
            this.salary = sal;
            
        }
        //declare indexer that searches using the indexer value

        public object this[int index]
        {
            get
            {
                if (index == 0) 
                    return this.empNumber;
                else if (index == 1)
                    return this.jobTitle;
                else if (index == 2)
                    return this.name;
                else if (index == 3)
                    return this.surname;
                else if (index == 4)
                    return this.salary;
                return null;

            }
            set 
            {
                if (index == 0)
                    this.empNumber = (string)value;
                else if (index == 1)
                    this.jobTitle = (string)value;
                else if (index == 2)
                    this.name = (string)value;
                else if (index ==3)
                    this.surname = (string)value;
                else 
                    this.salary = (double)value;
                
            }
        }

        //declare an indexer using string values
    }
}
