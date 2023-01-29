using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDep
{
      public class Employee

        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Gender { get; set; }

        public Employee(string firstName)
        {
            FirstName = firstName;
        }
            public Employee(int id)
            {
                ID = id;
            }
            public Employee(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
            public Employee(string firstName, string lastName, string gender) : this(firstName, lastName)
            {
                Gender = gender;
            }
            public Employee(string firstName, string lastName, string gender, int id) : this(firstName, lastName)
            {
                Gender = gender;
                ID = id;
            }

            public override string ToString()
            {
                return $"{FirstName}-{LastName}-{Gender}-{ID}";
            }
            //public static Employee Parse(string input) //firstName --- LastName;
            //{
            //    string firstName = input.Substring(0, input.IndexOf('-')).Trim();
            //    string lastName = input.Substring(0, input.LastIndexOf('-') + 1).Trim();

            //    return new Employee(firstName, lastName);
            //}
        }
}
