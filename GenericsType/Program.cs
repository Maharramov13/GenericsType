using GenericsType;

internal class Program
{
    public static void Main(string[] args)
    {
        CustomCollection collection = new CustomCollection();
        string choice;

        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Add Employee");
            Console.WriteLine("2) Find Employee by ID");
            Console.WriteLine("3) Print All Employees");

            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 3)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
            }

            switch (option)
            {
                case 1:
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter surname: ");
                    string surname = Console.ReadLine();
                    Console.Write("Enter age: ");
                    int age;
                    while (!int.TryParse(Console.ReadLine(), out age) || age < 1)
                    {
                        Console.WriteLine("Invalid age. Please enter a valid age.");
                    }
                    Console.Write("Enter salary: ");
                    double salary;
                    while (!double.TryParse(Console.ReadLine(), out salary) || salary < 0)
                    {
                        Console.WriteLine("Invalid salary. Please enter a valid salary.");
                    }
                    collection.AddEmployee(name, surname, age, salary);
                    break;
                case 2:
                    Console.Write("Enter ID: ");
                    int id;
                    while (!int.TryParse(Console.ReadLine(), out id) || id < 1)
                    {
                        Console.WriteLine("Invalid ID. Please enter a valid ID.");
                    }
                    Employee foundEmployee = collection.FindEmployeeById(id);
                    if (foundEmployee != null)
                    {
                        Console.WriteLine($"Employee found - ID: {foundEmployee.Id}, Name: {foundEmployee.Name}, Surname: {foundEmployee.Surname}, Age: {foundEmployee.Age}, Salary: {foundEmployee.Salary}");
                    }
                    else
                    {
                        Console.WriteLine("Employee not found.");
                    }
                    break;
                case 3:
                    collection.PrintAllEmployees();
                    break;
            }

            Console.WriteLine("Do you want to continue? (yes/no): ");
            choice = Console.ReadLine();
        } while (choice.ToLower() == "yes");
    }
}






   
