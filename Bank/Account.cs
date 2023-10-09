using System.Globalization;

namespace Bank;

public class Account
{
    public int Id { get; set; }
    public string Owner { get; set; }
    public double Balance { get; set; }


    public Account()
    {
        Balance = 0;
    }

    public Account(int id, string owner) : this()
    {
        Id = id;
        Owner = owner;
    }

    public Account(int id, string owner, double balance)
    {
        Id = id;
        Owner = owner;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Balance -= 5;
        }

        else
        {
            Console.WriteLine("Não é possível fazer o saque no momento. Saldo insuficiente!");
        }
    }

    public string Description()
    {
        return $"Conta: {Id}\n" +
            $"Titular: {Owner}\n" +
            $"Saldo: R$ {Balance.ToString("F2", CultureInfo.InvariantCulture)}.\n";
    }
}
