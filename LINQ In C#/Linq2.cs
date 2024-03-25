using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_In_C_
{
    internal class Linq2
    {
        class Dept
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }

        public void ManipulatingOfLINQ()
        {
            IEnumerable<Dept> dept = new List<Dept>()
        {
            new Dept {Id = 1, Name ="Accounting"},
            new Dept {Id = 2, Name ="AI_Dept" },
        };

            var DepartmentGee = dept.Where(emp => emp.Name == "Accounting");
            Console.WriteLine("The department is:");
            foreach (var DepartmentGees in DepartmentGee)
            {
                Console.WriteLine(DepartmentGees.Name);
            }

        }

       



    }
}
