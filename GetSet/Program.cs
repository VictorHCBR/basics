using GetSet;

Produto produto = new("Liquidificador", 250.00, 10);

Console.WriteLine(produto.Nome);

Console.Write("Informe a quantidade a ser adicionada ao estoque: ");
int adicionado = int.Parse(Console.ReadLine());

produto.Quantidade += adicionado;

Console.WriteLine(produto.Quantidade);