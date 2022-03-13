using ProductosSuperMarket;

namespace Program;

class Program
{
    public static void Main(string[] args)
    {
        Produto banana = new Produto(1, "Banana", 1.5);
        Produto maca = new Produto(2, "Maca", 3);

        Produto arroz = new Produto(3, "Arroz", 5);

        Carrinho carrinho = new Carrinho();
        carrinho.Add(banana);
        carrinho.Add(maca);
        carrinho.Add(arroz);
        Console.WriteLine("Total da compra = R$ " + carrinho.getTotal());
    }
}