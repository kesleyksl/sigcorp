using Sigcorp.Models;
using Sigcorp.Services.Exceptions;
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

        public void Insert(Cliente obj)
        {

            _context.Add(obj);
            _context.SaveChanges();
        }

        public Cliente BuscaPorID(int id)
        {
            return _context.Cliente.FirstOrDefault(obj => obj.ClienteID == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Cliente.Find(id);
            _context.Cliente.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Cliente obj)
        {
            if (!_context.Cliente.Any(x => x.ClienteID == obj.ClienteID))
            {
                throw new NotFoundException("Id não encontrado");
            }
            _context.Update(obj);
        }
    }
}
