using System.Globalization;

List<Employee> employees = new();
Console.Write("How many employees will be registered? ");
int numberOfEmployees = int.Parse(Console.ReadLine());

Console.WriteLine("-----------------------------------");

for (int i = 0; i < numberOfEmployees; i++)
{
    Employee employee = new();

    Console.WriteLine($"Employee #{i + 1}:");

    Console.Write("Id: ");
    employee.Id = int.Parse(Console.ReadLine());

    Console.Write("Name: ");
    employee.Name = Console.ReadLine();

    Console.Write("Salary: ");
    employee.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    employees.Add(employee);
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("--------------------------------------------------");

Console.Write("Enter the employee id that will have salary increase: ");
int id = int.Parse(Console.ReadLine());

int index = employees.FindIndex(x => x.Id == id);

if (index >= 0)
{
    Console.Write("Enter the percentage: ");
    double increasePercentage = double.Parse(Console.ReadLine());

    employees[index].UpdateSalary(increasePercentage);
}
else
{
    Console.WriteLine("Oops, this Id doesn't exist!");
}

Console.WriteLine("--------------------------------------------------");

Console.WriteLine("Updated list of employees:");
foreach (var employee in employees)
{
    Console.WriteLine($"{employee.Id}, {employee.Name}, {employee.Salary}.");
}