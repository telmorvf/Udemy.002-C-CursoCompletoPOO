using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _146_Inheritance_Contribuintes.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpendiditures { get; set; }

        public Individual() { }

        public Individual(string name, double anualIncome, double healthExpendiditures) 
            : base(name, anualIncome)
        {
            HealthExpendiditures = healthExpendiditures;
        }

        public override double Tax()
        {
            double tax = 0;
            if (AnualIncome < 20000.00)
            {
                tax = AnualIncome * 0.15;
            }
            else
            {
                tax = AnualIncome * 0.25;
            }

            if (HealthExpendiditures > 0)
            {
                tax -= HealthExpendiditures * 0.5;
            }
            return tax;
        }

    }
}
