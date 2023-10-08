var Reajustes = new Salarios();

Console.Write("Nome: ");
Reajustes.Name = Console.ReadLine();

Console.Write($"Salário Bruto: ");
Reajustes.SalarioBruto = Double.Parse(Console.ReadLine());

Console.Write("Imposto: ");
Reajustes.Imposto = Double.Parse(Console.ReadLine());

Console.WriteLine($"Funcionário: {Reajustes.Name}, ${Reajustes.SalarioLiquido()}\n");

Console.Write("Digite a porcentagem para aumentar o salário: ");
var porcentagem = Double.Parse(Console.ReadLine());

Reajustes.AumentarSalario(porcentagem);