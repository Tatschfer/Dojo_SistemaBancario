using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public class Cliente
    {
        public long id;
        public string nome;
        public List<int> contasAssociadas;

        public Cliente(long id, string nome, List<int> contasAssociadas)
        {
            this.id = id;
            this.nome = nome;
            this.contasAssociadas = new List<int>();
        }

    }
}
