namespace GetSet;

public class Produto
{
    private string? _nome;
    private double _preco;
    private int _quantidade;

    public Produto(string? nome, double preco, int quantidade)
    {
        _nome = nome;
        _preco = preco;
        _quantidade = quantidade;
    }

    public string? Nome
    {
        get => _nome;
        set
        {
            if (string.IsNullOrEmpty(value) && value.Length > 1)
            {
                _nome = value;
            }
        }
    }

    public double Preco
    {
        get => _preco;
        set => _preco = value;
    }

    public int Quantidade
    {
        get => _quantidade;
        set
        {
            if (value > 0)
            {
                _quantidade = value;
            }
        }
    }

    public double ValorTotalEmEstoque()
    {
        return _preco * _quantidade;
    }
}
