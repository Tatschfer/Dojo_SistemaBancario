using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public class ContaPoupanca : ContaBancaria
    {
        public double TaxaDeJuros;

        public ContaPoupanca(double taxaDeJuros)
        {
            this.TaxaDeJuros = taxaDeJuros;
        }
    }
}
