using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public class Banco
    {

        public List<Cliente> listaDeClientes = new List<Cliente>();
        
        public void CadastrarCliente(long id, string nome)
        {
            Cliente novoCliente = new Cliente(id, nome, new List<int>());
            long idDoNovoCliente = novoCliente.id;
            listaDeClientes.Add(novoCliente);
        }
  
        //Método para criar conta corrente

        public void CriarCC(long id, string nome, int numero, double saldo, double taxaDeManutencao)
        {
            Cliente clienteExistente = listaDeClientes.FirstOrDefault(c => c.id == id);

            //if (clienteExistente == null)
            //{
            //    CadastrarCliente(id, nome);
            //    ContaCorrente novaConta = new ContaCorrente(taxaDeManutencao);
            //    novaConta.ValidaNumeroConta(clienteExistente.contasAssociadas, numero);
            //    Console.WriteLine($"Conta Corrente {numero} adicionada com sucesso ao cliente {nome}");
            //}
                
            //else
            //{
            //    Cliente clienteEx;
            //    foreach (var cliente in listaDeClientes)
            //    {
            //        if (cliente.id == id)
            //            clienteEx = cliente;
            //    }
            //    ContaCorrente novaConta = new ContaCorrente(taxaDeManutencao);
            //    novaConta.ValidaNumeroConta(clienteExistente.contasAssociadas, numero);
            //    clienteExistente.contasAssociadas.Add(numero);
            //    Console.WriteLine($"Conta Corrente {numero} adicionada com sucesso ao cliente {clienteExistente.nome}");
            //}
               
        }

        //public void CriarCP(int numero, double saldo, double taxaDeJuros)
        //{
        //    Cliente clienteExistente = listaDeClientes.FirstOrDefault(c => c.id == id);

        //    if (clienteExistente == null)
        //        throw new Exception("Cliente não encontrado! Cadastre o cliente primeiro.");

        //    ContaPoupanca novaConta = new ContaPoupanca(taxaDeJuros);

        //    novaConta.ValidaConta(novaConta);
        //    novaConta.ValidaNumeroConta(clienteExistente.contasAssociadas, numero);

        //    clienteExistente.contasAssociadas.Add(numero);

        //    Console.WriteLine($"Conta {numero} adicionada com sucesso ao cliente {clienteExistente.nome}");
        //}

        public void ListarClientes()
        {
            foreach (var cliente in listaDeClientes)
            {
                Console.WriteLine($"Cliente ID: {cliente.id}, Nome: {cliente.nome}, Contas: {string.Join(", ", cliente.contasAssociadas)}");
            }
        }

    }
}
