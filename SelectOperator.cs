using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperatorExample
{
    class SelectOperator
    {

        public class Employee
        {
            public int EmployeeID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Gender { get; set; }
            public int AnnualSalary { get; set; }

            public static List<Employee> GetAllEmployees()
            {
                List<Employee> listEmployees = new List<Employee>
        {
            new Employee
            {
                EmployeeID = 101,
                FirstName = "Tom",
                LastName = "Daely",
                Gender = "Male",
                AnnualSalary = 60000
            },
            new Employee
            {
                EmployeeID = 102,
                FirstName = "Mike",
                LastName = "Mist",
                Gender = "Male",
                AnnualSalary = 72000
            },
            new Employee
            {
                EmployeeID = 103,
                FirstName = "Mary",
                LastName = "Lambeth",
                Gender = "Female",
                AnnualSalary = 48000
            },
            new Employee
            {
                EmployeeID = 104,
                FirstName = "Pam",
                LastName = "Penny",
                Gender = "Female",
                AnnualSalary = 84000
            },
        };

                return listEmployees;
            }
        }

        // Example 1: Retrieves just the EmployeeID property of all employees
        static void Main(string[] args)
        {
            IEnumerable<int> employeeIds = Employee.GetAllEmployees()
                                           .Select(emp => emp.EmployeeID);
            foreach (int id in employeeIds)
            {
                Console.WriteLine(id); // outPut   101
                                                // 102 
                                                // 103
                                                // 104 
            }



            //  Example 2: Projects FirstName &Gender properties of all employees into anonymous type.

            var result = Employee.GetAllEmployees().Select(emp => new
            {
                FirstName = emp.FirstName,
                Gender = emp.Gender
            });
            foreach (var v in result)
            {
                Console.WriteLine(v.FirstName + " - " + v.Gender); // out put= >     Tom - Male 
                                                                                    //Mark - Male
                                                                                    //Mary - Female 
                                                                                    //Parm -Female
            }
            var result1 = Employee.GetAllEmployees()
                .Where(emp => emp.AnnualSalary > 50000)
                .Select(emp => new
                {
                    Name = emp.FirstName,
                    Salary = emp.AnnualSalary,
                    Bonus = emp.AnnualSalary * .1
                });

            foreach (var v in result1)
            {
                Console.WriteLine(v.Name + " : " + v.Salary + " - " + v.Bonus);
            }
        }
    }
}
