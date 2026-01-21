using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public class ContaCorrente : ContaBancaria
    {
        public double TaxaDeManutencao;
        
        public ContaCorrente (double taxaDeManutencao)
        {
            this.TaxaDeManutencao = taxaDeManutencao;
        }


    }
}
