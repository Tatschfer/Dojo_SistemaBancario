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
            listaDeClientes.Add(novoCliente);
        }
  
        public void CriarConta(int numero, string tipo, double saldo, long id)
        {

            Cliente clienteExistente = listaDeClientes.FirstOrDefault(c => c.id == id);

            if (clienteExistente == null)
                throw new Exception("Cliente não encontrado! Cadastre o cliente primeiro.");


            ContaBancaria novaConta = new ContaBancaria(numero, tipo, saldo);
            

            novaConta.ValidaConta(saldo, tipo);
            novaConta.ValidaNumeroConta(clienteExistente.contasAssociadas, numero);

            clienteExistente.contasAssociadas.Add(numero);

            Console.WriteLine($"Conta {numero} adicionada com sucesso ao cliente {clienteExistente.nome}");
        }

        public void ListarClientes()
        {
            foreach (var cliente in listaDeClientes)
            {
                Console.WriteLine($"Cliente ID: {cliente.id}, Nome: {cliente.nome}, Contas: {string.Join(", ", cliente.contasAssociadas)}");
            }
        }

    }
}
