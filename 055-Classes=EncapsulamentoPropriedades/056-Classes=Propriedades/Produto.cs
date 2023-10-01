using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_Classes_Propriedades
{
    internal class Produto
    {
        // Atributos
        private string _nome;

        //Propriedades
        public string Nome
        {
            get 
            {
                return _nome;
            }
            set 
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public double Preco { get ; private set; }
        public int Quantidade { get; private set; }


        //Construtores
        public Produto()
        {
            Quantidade = 10;
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        // Metodos
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        //override - Polimorfismo
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
