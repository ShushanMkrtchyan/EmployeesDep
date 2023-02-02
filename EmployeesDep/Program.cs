using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace EmployeesDep
{
    static class ShowMenu  
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
            BlocknotDep blockdep = new BlocknotDep();


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
                        blockdep.Add(dp);
                                                                 
                        Employee employee = new Employee(firstName, lastName, gender);
                        int newid = blocknot.Add(employee);
                       
                        Console.WriteLine($"Employee is added with this ID:{newid}");

                        blocknot.SaveToFile1();
                        blockdep.SaveToFile2();
                        break;

                    case MenuNotes.FindEmployees:

                        Console.Write("Write Item to search for: ");


                        string nameToFind = Console.ReadLine();

                        List<Employee> empls = blocknot.Find(e => e.FirstName == nameToFind).ToList();
                        foreach (Employee item in empls)
                        {
                            Console.WriteLine($"{item.FirstName}-{item.LastName}-{item.Gender}-{item.ID}");
                        }
                        blocknot.LoadFromFile1();
                        break;


                    case MenuNotes.RemoveEmployee:
                        Console.Write("Please enter ID: ");
                        int id1 = int.Parse(Console.ReadLine());
                        var removeid = blocknot.Remove(id1);
                        Console.WriteLine($"Employee with {id1} id is removed");
                        blocknot.SaveToFile1();
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