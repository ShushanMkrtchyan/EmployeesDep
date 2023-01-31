using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDep
{
    public class BlocknotEmp
    {
        public const string FileName ="BlocknotEmp.txt";
        private List<Employee> employees;

        public BlocknotEmp()
        {
            employees = new List<Employee>();
        }

        public int Add(Employee employee)
        {
            int id = (new Random()).Next(1000);

            while (ContainsbyId(id))
            {
                id = (new Random()).Next(1000);
            }
            employee.ID = id;
            this.employees.Add(employee);
            return id;
     
        }

        
        private bool ContainsbyId(int id)
        {
            foreach (Employee employee in employees)
            {
                if (employee.ID == id)
                {
                    return true;  //unikal chi, as krknvuma id
                }
            }
            return false;  //unikala, vorochetev chka krknovx id

        }
        public IEnumerable<Employee> Find(string firstName)
        {
            foreach (Employee employee in this.employees)
            {
                if (employee.FirstName.ToLower() == firstName.ToLower())
                {
                    yield return employee;
                }
            }
        }
        public Employee Remove(int employeeid)
        {
            foreach (Employee emp in this.employees)
            {
                if (employeeid == emp.ID)
                {
                    employees.Remove(emp);
                    return emp;
                }
            }
            return null;
        }

        public void ShowAll()
        {
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
        public bool SaveToFile()
        {
            try
            {
                using StreamWriter stream = new StreamWriter(FileName);

                foreach (Employee empl in this.employees)
                {
                    stream.WriteLine(empl);
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public void LoadFromFile()
        {
            this.employees.Clear();
            using (StreamReader streamReader = new StreamReader(FileName))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Employee employee = Employee.Parse(line);
                    this.employees.Add(employee);
                }
            }
        }
        public static void ShowAll(Employee employee, List<Employee> employees)
        {
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }

    }
}
