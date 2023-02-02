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
             public Employee() {}
           
             public Employee(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
            public Employee(string firstName, string lastName, string gender) : this(firstName, lastName)
            {
                Gender = gender;
            }
       
       
        public override string ToString()
            {
                return $"{FirstName}-{LastName}-{Gender}-{ID}";
            }
        public static Employee Parse(string input) //fistname-lastname-gender-id;
        {
            string[] array = input.Split('-');
            if (array.Length != 4)
            {
                throw new ArgumentException("Invalid input format"); 
            }

            string firstname = array[0].Trim();
            string lastname = array[1].Trim();
            string gender = array[2].Trim();
            int id = Int32.Parse(array[3].Trim());

            return new Employee()
            {
                ID = id,
                FirstName = firstname,
                LastName = lastname,
                Gender = gender
            };
        }
    }
}
