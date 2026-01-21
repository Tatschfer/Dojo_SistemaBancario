using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();

            //banco.CadastrarCliente(12345678900, "Paulo Prates");
            banco.CriarCC(12345678900, "Paulo Prates", 123459, 150.00, 2.50);

            banco.ListarClientes();


        }
    }
}
