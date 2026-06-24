class Employee
{
    public int EmployeeId;
    public string Name;
    public string Position;
    public double Salary;

    public Employee(int id, string name, string position, double salary)
    {
        EmployeeId = id;
        Name = name;
        Position = position;
        Salary = salary;
    }
}

class EmployeeManagement
{
    private Employee[] employees = new Employee[10];
    private int count = 0;

    public void AddEmployee(Employee employee)
    {
        if (count < employees.Length)
        {
            employees[count] = employee;
            count++;
            Console.WriteLine("Employee added successfully.");
        }
        else
        {
            Console.WriteLine("Employee array is full.");
        }
    }

    public void SearchEmployee(int employeeId)
    {
        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == employeeId)
            {
                Console.WriteLine(
                    employees[i].EmployeeId + " " +
                    employees[i].Name + " " +
                    employees[i].Position + " " +
                    employees[i].Salary
                );
                return;
            }
        }

        Console.WriteLine("Employee not found.");
    }

    public void TraverseEmployees()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(
                employees[i].EmployeeId + " " +
                employees[i].Name + " " +
                employees[i].Position + " " +
                employees[i].Salary
            );
        }
    }

    public void DeleteEmployee(int employeeId)
    {
        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == employeeId)
            {
                for (int j = i; j < count - 1; j++)
                {
                    employees[j] = employees[j + 1];
                }

                employees[count - 1] = null;
                count--;

                Console.WriteLine("Employee deleted successfully.");
                return;
            }
        }

        Console.WriteLine("Employee not found.");
    }
}

class Program
{
    static void Main()
    {
        EmployeeManagement management = new EmployeeManagement();

        management.AddEmployee(new Employee(1, "Ayan", "Developer", 50000));
        management.AddEmployee(new Employee(2, "Rahul", "Tester", 40000));
        management.AddEmployee(new Employee(3, "Priya", "Manager", 70000));

        Console.WriteLine("\nAll Employees:");
        management.TraverseEmployees();

        Console.WriteLine("\nSearch Employee with ID 2:");
        management.SearchEmployee(2);

        management.DeleteEmployee(2);

        Console.WriteLine("\nAfter Deleting Employee with ID 2:");
        management.TraverseEmployees();
    }
}