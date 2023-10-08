using System.Globalization;

namespace Scholar;

public class Student
{
    public string Name { get; set; }
    public List<double> Grades { get; set; } = new List<double>();

    public void Status()
    {
        double sum = 0.0;

        foreach (var grade in Grades)
            sum += grade;

        Console.WriteLine($"NOTA FINAL = {String.Format("{0:N2}", sum)}");

        if (sum >= 60.0)
            Console.WriteLine("APROVADO");

        else
            Console.WriteLine($"REPROVADO\nFALTARAM {String.Format("{0:N2}", (60.0 - sum).ToString(CultureInfo.InvariantCulture))} PONTOS");
    }
}
