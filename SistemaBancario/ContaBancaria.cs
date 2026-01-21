using System;
using System.Collections.Generic;

namespace SistemaBancario
{
    public class ContaBancaria
    {
        public int numero;
        public string tipo;
        public double saldo;

        public ContaBancaria(int numero, string tipo, double saldo)
        {
            this.numero = numero;
            this.tipo = tipo;
            this.saldo = saldo;
        }

        public void ValidaConta(double saldo, string tipo)
        {

            if (tipo != "corrente" && tipo != "poupança")
            {
                throw new ArgumentException("Tipo de conta inválido.");
            }

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
