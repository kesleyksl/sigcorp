using Sigcorp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sigcorp.Services
{
    public class ProdutoService
    {
        private readonly SigcorpContext _context;

        public ProdutoService(SigcorpContext context)
        {
            _context = context;
        }

        public List<Produto> BuscarProdutos()
        {
            return _context.Produto.OrderBy(x => x.Nome).ToList();
        }
    }
}
