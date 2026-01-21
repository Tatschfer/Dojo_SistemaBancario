using System;
using System.Collections.Generic;

namespace SistemaBancario
{
    public class ContaBancaria
    {
        public int numero;
        public double saldo;

        public ContaBancaria(int numero, double saldo)
        {
            this.numero = numero;
            this.saldo = saldo;
        }

        public ContaBancaria(){}

        public bool ValidaConta(ContaBancaria conta) 
            { 
            return conta is ContaCorrente || conta is ContaPoupanca;
            }

        public void ValidaNumeroConta(List<int> contasAssociadas, int numeroConta)
        {
            if (contasAssociadas.Contains(numeroConta))
            {
                throw new ArgumentException("Número da conta inválido.");
            }
        }

    }
}
