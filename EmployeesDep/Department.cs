using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDep
{
    public class Department
    {
        public string Name { get; set; }
        public Department(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
        
        

      
    }
}
