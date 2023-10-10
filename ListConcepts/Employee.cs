public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }

    public void UpdateSalary(double percentage)
    {
        Salary += Salary * (percentage / 100);
    }
}