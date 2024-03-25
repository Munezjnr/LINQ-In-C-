using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_In_C_
{
    internal class LearningLINQ
    {
        class Employees
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }

            public int Salary { get; set; }

        }


        class Department
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }

        public void ManipulateLINQ()
        {
            IEnumerable<Employees> employees = new List<Employees>()
             {
                 new Employees {Id = 1, Name = "Bosco", Department="Music", Salary = 50000 },
                 new Employees {Id = 2, Name = "Jay", Department="Accounting", Salary = 80000 },
                 new Employees {Id = 3, Name = "Emma", Department="Tech", Salary = 180000 },
                 new Employees {Id = 4, Name = "IK", Department="C#", Salary = 60000 },
             };

            var musicEmployee = employees.Where(emp => emp.Department == "Music");
            Console.WriteLine("The employess is the music class are:");
            foreach (var musicemployee in musicEmployee)
            {
                Console.WriteLine(musicemployee.Name);
            }

            Console.WriteLine("The employess and their music salary are:");
            var EmployeeSalaries = employees.OrderByDescending(emp => emp.Salary);

            foreach (var EmployeeSalary in EmployeeSalaries)
            {
                Console.WriteLine($"{EmployeeSalary.Name} : {EmployeeSalary.Salary}");
            }

            IEnumerable<Department> department = new List<Department>()
        {
            new Department {Id = 1, Name ="Music"},
            new Department {Id = 2, Name ="Accounting"},
            new Department {Id = 3, Name ="Tech" },
            new Department {Id = 4, Name = "C#" }
        };

            var joinEmployeesAndDepartments = employees.Join(
                department,
                emp => emp.Department,
                dept => dept.Name,
                (emp, dept) => new { emp.Name, Department = dept.Name });
            Console.WriteLine("The join for employees and Departments are :");
            foreach(var joinedemployeddept in joinEmployeesAndDepartments)
            {
                Console.WriteLine($"{joinedemployeddept.Name} : {joinedemployeddept.Department}");
            }
                
           
        }
    }
}
