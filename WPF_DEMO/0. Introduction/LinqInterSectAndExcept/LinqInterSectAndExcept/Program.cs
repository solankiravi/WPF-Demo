using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqInterSectAndExcept
{
    class Program
    {
         static List<AllEmployee> allemp = new List<AllEmployee>();
        static List<SelectedEmp> selEmp = new List<SelectedEmp>();

        
        static void Main(string[] args)
        {
            allemp.Add(new AllEmployee { EmpId = 1, Name = "Ravi" });
            allemp.Add(new AllEmployee { EmpId = 2, Name = "Vicky" });
            allemp.Add(new AllEmployee { EmpId = 3, Name = "Anil" });
            allemp.Add(new AllEmployee { EmpId = 4, Name = "Solanki" });
            allemp.Add(new AllEmployee { EmpId = 5, Name = "Vikash" });

            selEmp.Add(new SelectedEmp { EmpId = 1, Name = "Ravi" });
            selEmp.Add(new SelectedEmp { EmpId = 2, Name = "Vicky" });
            selEmp.Add(new SelectedEmp { EmpId = 3, Name = "Anil" });
            Program p = new Program();
           
        }

       
    }
    class AllEmployee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }

        
    }
    class SelectedEmp
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
    }
}
