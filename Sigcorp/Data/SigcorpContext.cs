using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sigcorp.Models
{
    public class SigcorpContext : DbContext
    {
        public SigcorpContext (DbContextOptions<SigcorpContext> options)
            : base(options)
        {
        }

        public DbSet<Sigcorp.Models.Produto> Produto { get; set; }

        public DbSet<Sigcorp.Models.Cliente> Cliente { get; set; }

        public DbSet<Sigcorp.Models.PedidoCompra> PedidoCompra { get; set; }
    }
}
