//cliente
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Sigcorp.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        [Display(Name = "Nome")]
        public string NomeCompleto { get; set; }
        [Display(Name = "CPF")]
        
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$")]
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

        
    }
}
