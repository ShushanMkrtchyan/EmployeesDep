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
                    Console.WriteLine();
                    Console.Write("Please Select item -> ");

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

                                                   
                        Employee employee = new Employee(firstName, lastName, gender );
                        int newid = blocknot.Add(employee);

                        Console.WriteLine($"Employee is added with this ID:{newid}");

                        blocknot.SaveToFile();
                        
                        break;

                    case MenuNotes.FindEmployees:
                        blocknot.LoadFromFile();
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
                        blocknot.SaveToFile();

                                                         
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