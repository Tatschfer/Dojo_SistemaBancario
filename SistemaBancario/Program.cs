using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();

            banco.CadastrarCliente(12345678900, "Paulo Prates");
            banco.CriarConta(12345, "corrente", 1000.0, 12345678900);
            banco.ListarClientes();
        }
    }
}
