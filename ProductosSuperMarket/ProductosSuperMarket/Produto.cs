namespace ProductosSuperMarket
{
    public class Produto
    {
        private int _id;
        private string _nome;
        private double _valor;

        public Produto(int id, string nome, double valor)
        { 
            this._id = id;
            this._nome = nome;
            this._valor = valor;
        }

        public double getValor()
        {
            return _valor;
        }

        public string toString()
        {
            return "{id= "+_id+"; nome= "+_nome+"; valor= " +_valor+"}";
        }

        public string getNome()
        {
            return _nome;
        }
    }
}
