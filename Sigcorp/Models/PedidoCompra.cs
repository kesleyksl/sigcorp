//pedido compras

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sigcorp.Models
{
    public class PedidoCompra
    {
        public int PedidoCompraID { get; set; }
        public int NumeroPedido { get; set; }
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
        public Cliente Cliente { get; set; }
        public double Total { get; set; }

        public PedidoCompra()
        {
        }

        public PedidoCompra(int pedidoCompraID, int numeroPedido, Cliente cliente, double total)
        {
            PedidoCompraID = pedidoCompraID;
            NumeroPedido = numeroPedido;
            Cliente = cliente;
            Total = total;
        }

        public void AddProduto(Produto produto)
        {
            Produtos.Add(produto);
        }
        public void RemoveProduto(Produto produto)
        {
            Produtos.Remove(produto);
        }

        public double TotalPedido()
        {
            var total = Produtos.Sum(p => p.ValorUnitario);
            return total;
        }
    }
}
