using Bank;

Console.Write("Entre o numero da conta: ");
int id = int.Parse(Console.ReadLine());

Console.Write("Entre o titular da conta: ");
string owner = Console.ReadLine();

Console.Write("Haverá depósito inicial (s/n)? ");
char question = char.Parse(Console.ReadLine());

Account account;

if (ToLower(question) == 's')
{
    Console.Write("Informe o valor do depósito inicial: ");
    int initialDeposit = int.Parse(Console.ReadLine());

    account = new(id, owner, initialDeposit);
    Console.WriteLine("Dados: ");
    Console.WriteLine(account.Description());
}

else
{
    account = new(id, owner);
    Console.WriteLine("Dados: ");
    Console.WriteLine(account.Description());
}

Console.Write("Entre um valor para depósito: ");
double amount = double.Parse(Console.ReadLine());

account.Deposit(amount);

Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(account.Description());

Console.Write("Entre um valor para saque: ");
double withdrawAmount = double.Parse(Console.ReadLine());

account.Withdraw(withdrawAmount);

Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(account.Description());

static char ToLower(char c)
{
    return char.Parse(c.ToString().ToLower());
}