public class Salarios
{
    public string? Name { get; set; }
    public double SalarioBruto { get; set; }
    public double Imposto { get; set; }

    public double SalarioLiquido()
    {
        return SalarioBruto - Imposto;
    }

    public void AumentarSalario(double porcentagem)
    {
        Console.WriteLine($" Dados Atualizados: {Name}, ${SalarioBruto + SalarioBruto * (porcentagem * 0.01) - Imposto}");
    }
}
