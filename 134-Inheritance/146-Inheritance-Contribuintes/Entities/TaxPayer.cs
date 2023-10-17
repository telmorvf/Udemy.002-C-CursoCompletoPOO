using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _146_Inheritance_Contribuintes.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }

        public double AnualIncome { get; set; }

        public TaxPayer() { }

        // Cuidado Construtor em Modo Protected
        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
