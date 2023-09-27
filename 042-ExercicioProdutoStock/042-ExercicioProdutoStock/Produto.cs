using System.Globalization;

namespace _042_ExercicioProdutoStock
{
    class Produto
    {
        // Propriedade
        public string Nome { get; set; }

        public double Preco { get; set; }

        public int Quantidade { get; set; }


        //Metodos

        public double PrecoTotalEmStock()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        //Override Polimorfismo
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + PrecoTotalEmStock().ToString("F2", CultureInfo.InvariantCulture);

        }


    }
}
