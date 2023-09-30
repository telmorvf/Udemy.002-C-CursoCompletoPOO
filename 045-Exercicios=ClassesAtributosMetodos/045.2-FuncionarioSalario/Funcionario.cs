using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _045._2_FuncionarioSalario
{
    internal class Funcionario
    {
        public string Nome { get; set; }

        public double SalarioBruto { get; set; }

        public double Imposto { get; set; } 

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double percentagem)
        {
            SalarioBruto += (SalarioBruto * percentagem) / 100;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
