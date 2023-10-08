namespace Geometry;

public class Rectangle
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public double Area(double altura, double largura)
    {
        return altura * largura;
    }

    public double Perimetro(double altura, double largura)
    {
        return 2 * altura + 2 * largura;
    }

    public double Diagonal(double altura, double largura)
    {
        double quadradoAltura = altura * altura;
        double quadradoLargura = largura * largura;

        return Math.Sqrt(quadradoAltura + quadradoLargura);
    }
}
