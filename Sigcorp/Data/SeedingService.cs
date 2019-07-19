using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sigcorp.Models;
namespace Sigcorp.Data
{
    public class SeedingService
    {
        
        private SigcorpContext _context;

        public SeedingService(SigcorpContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.PedidoCompra.Any() || _context.Cliente.Any() || _context.Produto.Any())
            {
                return; //Banco de dados ja populado
            }
            Produto p1 = new Produto { ProdutoID = 1, Nome = "Perfume 212", ValorUnitario = 250.00 };
            Produto p2 = new Produto { ProdutoID = 2, Nome = "Perfume Animale", ValorUnitario = 180.00 };
            Produto p3 = new Produto { ProdutoID = 3, Nome = "Perfume Polo Black", ValorUnitario = 400.00 };
            Produto p4 = new Produto { ProdutoID = 4, Nome = "Perfume 1Million", ValorUnitario = 420.00 };
            Produto p5 = new Produto { ProdutoID = 5, Nome = "Perfume Angel", ValorUnitario = 300.00 };
            Produto p6 = new Produto { ProdutoID = 6, Nome = "Perfume Spice Bomb", ValorUnitario = 500.00 };
            Produto p7 = new Produto { ProdutoID = 7, Nome = "Perfume Invictus", ValorUnitario = 4000.00 };
            Produto p8 = new Produto { ProdutoID = 8, Nome = "Perfume Ck BE", ValorUnitario = 280.00 };
            Produto p9 = new Produto { ProdutoID = 9, Nome = "Perfume Secrets", ValorUnitario = 180.00 };
            Produto p10 = new Produto { ProdutoID = 10, Nome = "Perfume 212 Vip", ValorUnitario = 350.00 };
            Produto p11= new Produto { ProdutoID = 11, Nome = "Perfume Bvlgari", ValorUnitario = 200.00 };

            Cliente c1 = new Cliente {ClienteID = 1, NomeCompleto = "João da Silva", Cpf = "333.444.444-76" };
            Cliente c2 = new Cliente { ClienteID = 2, NomeCompleto = "João Pereira", Cpf = "333.444.532-76" };
            Cliente c3 = new Cliente { ClienteID = 3, NomeCompleto = "João de Deus", Cpf = "333.444.344-76" };
            Cliente c4 = new Cliente { ClienteID = 4, NomeCompleto = "João Paulo", Cpf = "333.444.424-76" };
            Cliente c5 = new Cliente { ClienteID = 5, NomeCompleto = "João Pedro", Cpf = "333.444.344-76" };
            Cliente c6 = new Cliente { ClienteID = 6, NomeCompleto = "João de Mello", Cpf = "333.424.444-76" };
            Cliente c7 = new Cliente { ClienteID = 7, NomeCompleto = "João Severino", Cpf = "333.444.544-76" };
            Cliente c8 = new Cliente { ClienteID = 8, NomeCompleto = "João Antonio", Cpf = "333.484.444-76" };
            Cliente c9 = new Cliente { ClienteID = 9, NomeCompleto = "João de Paula", Cpf = "353.444.444-76" };
            Cliente c10 = new Cliente { ClienteID = 10, NomeCompleto = "João Barbosa", Cpf = "313.444.444-76" };
            Cliente c11 = new Cliente { ClienteID = 11, NomeCompleto = "João Vidal", Cpf = "338.444.444-76" };

            PedidoCompra pc1 = new PedidoCompra { PedidoCompraID = 1, NumeroPedido = 0001, Cliente = c1 };
            PedidoCompra pc2 = new PedidoCompra { PedidoCompraID = 2, NumeroPedido = 0002, Cliente = c2 };
            PedidoCompra pc3 = new PedidoCompra { PedidoCompraID = 3, NumeroPedido = 0003, Cliente = c3 };
            PedidoCompra pc4 = new PedidoCompra { PedidoCompraID = 4, NumeroPedido = 0004, Cliente = c4 };
            PedidoCompra pc5 = new PedidoCompra { PedidoCompraID = 5, NumeroPedido = 0005, Cliente = c5 };
            PedidoCompra pc6 = new PedidoCompra { PedidoCompraID = 6, NumeroPedido = 0006, Cliente = c6 };
            PedidoCompra pc7 = new PedidoCompra { PedidoCompraID = 7, NumeroPedido = 0007, Cliente = c7 };
            PedidoCompra pc8 = new PedidoCompra { PedidoCompraID = 8, NumeroPedido = 0008, Cliente = c8 };
            PedidoCompra pc9 = new PedidoCompra { PedidoCompraID = 9, NumeroPedido = 0009, Cliente = c9 };
            PedidoCompra pc10 = new PedidoCompra { PedidoCompraID = 10, NumeroPedido = 0010, Cliente = c10 };
            PedidoCompra pc11 = new PedidoCompra { PedidoCompraID = 11, NumeroPedido = 0011, Cliente = c11 };
            PedidoCompra pc12 = new PedidoCompra { PedidoCompraID = 12, NumeroPedido = 0012, Cliente = c1 };
            PedidoCompra pc13 = new PedidoCompra { PedidoCompraID = 13, NumeroPedido = 0013, Cliente = c2 };
            PedidoCompra pc14 = new PedidoCompra { PedidoCompraID = 14, NumeroPedido = 0014, Cliente = c3 };
            PedidoCompra pc15 = new PedidoCompra { PedidoCompraID = 15, NumeroPedido = 0015, Cliente = c4 };

            _context.Cliente.AddRange(c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11);
            _context.Produto.AddRange(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
            _context.PedidoCompra.AddRange(pc1, pc2, pc3, pc4, pc5, pc6, pc7, pc8, pc9, pc10, pc11, pc12, pc13, pc14, pc15);

            _context.SaveChanges();
        }

    }
}
