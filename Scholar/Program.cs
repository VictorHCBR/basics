using Scholar;

var Std = new Student();

Console.Write("Nome do Aluno: ");
Std.Name = Console.ReadLine();

Console.WriteLine("Digite as três notas dos aluno:");
for (int i = 0; i < 3; i++)
{
    var novas = double.Parse(Console.ReadLine());
    Std.Grades.Add(novas);
}

Std.Status();