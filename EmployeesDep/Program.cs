using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace EmployeesDep
{
    static class ShowMenu  //Helper
    {
        public static void Show()
        {
            MenuNotes[] menuNotes = Enum.GetValues<MenuNotes>();
            foreach (MenuNotes note in menuNotes)
            {
                string str = note.ToString();

                Console.WriteLine($"{(int)note}){str}");
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {

            BlocknotEmp blocknot = new BlocknotEmp();
            do
            {
                ShowMenu.Show();
                int choice = 0;
                while (true)
                {
                    Console.Write("select item -> ");

                    if (Int32.TryParse(Console.ReadLine(), out choice) &&
                        Enum.IsDefined<MenuNotes>((MenuNotes)choice))
                        break;

                    Console.WriteLine("Illegal symbol");
                }

                MenuNotes selectedone = (MenuNotes)choice;

                switch (selectedone)
                {
                    case MenuNotes.AddEmployees:
                        Console.Write("FirstName = ");
                        string firstName = Console.ReadLine();
                        Console.Write("LastName = ");
                        string lastName = Console.ReadLine();

                        Console.Write("Gender = ");
                        string gender = Console.ReadLine();

                        Console.Write("Department = ");
                        string department = Console.ReadLine();
                        Department dp = new Department(department);

                        //int id ;
                        //do
                        //{
                        //    Console.Write("ID = ");
                        //}
                        //while (!int.TryParse(Console.ReadLine(), out id));
                     
                        
                        Employee employee = new Employee(firstName, lastName, gender );
                        int newid = blocknot.Add(employee);
                        Console.WriteLine($"Employees is added with this ID:{newid}");
                        break;

                    case MenuNotes.FindEmployees:
                        Console.Write("Write name to search for: ");
                        string nameToFind = Console.ReadLine();
                        
                        IEnumerable<Employee> emp = blocknot.Find(nameToFind);

                        foreach (Employee one in emp)

                            if (one != null)
                            {
                                Console.WriteLine(one);
                            }
                            else

                            {
                                Console.WriteLine($"{emp} not found");
                            }

                        break;

                    case MenuNotes.RemoveEmployee:
                        Console.Write("Please enter ID: ");
                        int id = int.Parse(Console.ReadLine());
                        var removeid = blocknot.Remove(id);
                        Console.WriteLine($"Employee with {id} id is removed");

                                                         
                        break;
                    case MenuNotes.ShowAllEmployees:
                        blocknot.ShowAll();
                        break;
                    default:
                        break;


                }

            } while (true);
        }
    }
    
}