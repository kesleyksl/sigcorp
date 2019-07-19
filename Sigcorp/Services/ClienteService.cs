using Sigcorp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sigcorp.Services
{
    public class ClienteService
    {
        private readonly SigcorpContext _context;

        public ClienteService(SigcorpContext context)
        {
            _context = context;
        }

        public List<Cliente> BuscaClientes()
        {
            return _context.Cliente.ToList();
        }
    }
}
