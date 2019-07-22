using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sigcorp.Models
{
    public class Produto
    {

     
        public int ProdutoID { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Valor unitário")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double ValorUnitario { get; set; }

        
    }
}
