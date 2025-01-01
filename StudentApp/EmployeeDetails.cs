using demodotnet.DotnetProj1;
using StudentApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demodotnet.StudentApp
{
    internal class EmployeeDetails
    {
        //public int eid { get; set; }
        //List<int> eid = new List<int>() {  };
        //List<string> ename = new List<string>() {  };

        List<Employee> e = new List<Employee>();


        public void ShowDetails()
        {
            Console.WriteLine("Employee Details");
            

            for(int i = 0; i < e.Count; i++)
            {
                Console.WriteLine("-------------------------");
                Console.Write("Employee ID: ");
                Console.WriteLine(e[i].eid);
                Console.Write("Employee Name: ");
                Console.WriteLine(e[i].ename);
            }

        }

        public void AddEmployee()
        {
            Console.Write("Enter Employee ID: ");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            string empname = Console.ReadLine();
            int pos = -1;

            for (int i = 0; i < e.Count; i++)
            {
                if (e[i].ename.Equals(empname, StringComparison.OrdinalIgnoreCase) || e[i].eid == empid)
                {
                    pos = i;
                    break;
                }
                
            }

            if (pos >= 0)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                e.Add(new Employee(empid, empname));
                ShowDetails();
            }
        }

        public void UpdateEmployee()
        {
            Console.Write("Enter the Employee ID to update: ");
            int uempid = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < e.Count; i++)
            {
                if (e[i].eid == uempid)
                {

                    e[i].eid = uempid;
                    break;
                }
                else
                {
                    count += 1;
                }
            }
            if (count == e.Count)
            {
                Console.WriteLine($"The ID {uempid}  is not in the array");
            }
        }

        public void EmployeeMenu()
        {
            Console.WriteLine("********** Employee Details **********");
            Console.WriteLine("1. Display Employee List");
            Console.WriteLine("2. Add Employee");
            Console.WriteLine("3. Update Employee");
            Console.WriteLine("4. Delete Employee");
            Console.WriteLine("5. Exit Menu");
            Console.Write("Enter your choice 1 - 5: ");
            int ch = Convert.ToInt32(Console.ReadLine());


            switch (ch)
            {
                case 1:
                    ShowDetails();
                    EmployeeMenu();
                    break;
                case 2:
                    AddEmployee();
                    EmployeeMenu();
                    break;
                case 3:
                    //UpdateFruit();
                    //FruitsMenu();
                    break;
                case 4:
                    //Deletefruit();
                    //FruitsMenu();
                    break;
                case 5:
                    break;
                default:
                    //FruitsMenu();
                    break;
            }
        }


    }
}
