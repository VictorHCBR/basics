var Retangulo = new Geometry.Rectangle();

Console.WriteLine("Entre a largura e altura do retângulo: ");
Retangulo.Altura = double.Parse(Console.ReadLine());
Retangulo.Largura = double.Parse(Console.ReadLine());

Console.WriteLine($"AREA = {String.Format("{0:N2}", Retangulo.Area(Retangulo.Altura, Retangulo.Largura))}");
Console.WriteLine($"PERIMETRO = {String.Format("{0:N2}", Retangulo.Perimetro(Retangulo.Altura, Retangulo.Largura))}");
Console.WriteLine($"DIAGONAL = {String.Format("{0:N2}", Retangulo.Diagonal(Retangulo.Altura, Retangulo.Largura))}");

