//cliente
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sigcorp.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }

        public Cliente()
        {
        }

        public Cliente(int clienteID, string nomeCompleto, string cpf)
        {
            ClienteID = clienteID;
            NomeCompleto = nomeCompleto;
            Cpf = cpf;
        }

        public int MyProperty { get; set; }
    }
}
