using System.Globalization;

namespace FakeERP;

public class Item
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Item(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public double TotalWorth()
    {
        return Quantity * Price;
    }

    public string InventoryDescription()
    {
        string description = $"\nItem: {Name}\n " +
            $"Preço: {Price.ToString("F2", CultureInfo.InvariantCulture)}\n" +
            $"Quantidade em Estoque: {Quantity}\n" +
            $"Valor total do Estoque: {TotalWorth().ToString("F2", CultureInfo.InvariantCulture)}";

        return description;
    }
}
