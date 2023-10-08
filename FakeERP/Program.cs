using FakeERP;
using System.Globalization;

Console.Write("Informe o nome do produto: ");
var name = Console.ReadLine();

Console.Write("Informe o valor do produto: ");
var price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Informe a quantidade de itens disponíveis:");
int quantity = int.Parse(Console.ReadLine());


Item item = new(name, price, quantity);

Console.WriteLine(item.InventoryDescription(), CultureInfo.InvariantCulture);