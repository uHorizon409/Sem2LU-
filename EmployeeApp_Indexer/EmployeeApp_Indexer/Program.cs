using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace EmployeeApp_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("emp001", "Director", "Bagezile", "Zuma", 5000);
            //Console.WriteLine("Employee Number : " + emp[0]);
            //Console.WriteLine("Employee Title : " + emp[1]);
            //Console.WriteLine("Employee Name : " + emp[2]);
            //Console.WriteLine("Employee Surname: " + emp[3]);
            //Console.WriteLine("Employee Salary : " + emp[4]);

            for (int i = 0; i < emp i++)
            {
                Console.WriteLine(emp[i]);
            }
            // Print using for loop

            //string[] labels = {
            //        "Employee Number : ",
            //        "Employee Title : ",
            //        "Employee Name : ",
            //        "Employee Surname: ",
            //        "Employee Salary : "
            //    };

            //string[] values = {
            //    emp.EmpNumber,
            //    emp.JobTitle,
            //    emp.Name,
            //    emp.Surname,
            //    emp.Salary.ToString()
            //};


            //for (int i = 0; i < labels.Length; i++)
            //{
            //    Console.WriteLine(labels[i] + values[i]);
            //}
        }
    }
}
