using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_In_C_
{
    internal class Linq1
    {
        class Workers
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }

            public int Salary { get; set; }
        }

        public void ManipulationOfLINQ()
        {
            IEnumerable<Workers> Workers = new List<Workers>()
             {
                 new Workers {Id = 1, Name = "Bosco", Department="Music", Salary = 50000 },
                 new Workers {Id = 2, Name = "Jay", Department="Accounting", Salary = 80000 },
             };

            Console.WriteLine("The workers and their  salary are:");
            var WorkersSalaries = Workers.OrderByDescending(emp => emp.Salary);

            foreach (var WorkersSalary in WorkersSalaries)
            {
                Console.WriteLine($"{WorkersSalary.Name} : {WorkersSalary.Salary}");
            }
        }
    }
}
