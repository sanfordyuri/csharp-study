namespace ProductosSuperMarket
{
    public class Carrinho : List<Produto>
    {
        public double getTotal()
        {
            return this.Where(p => p.getValor() > 0).Sum(p => p.getValor());
        }
    }
}

// Carrinho herda de Lista de Produtos, logo o meu carrinho É uma lista de produtos

// Classe Cachorro : Animal, logo o meu Cachorro ele É um animal 

// Linqs
