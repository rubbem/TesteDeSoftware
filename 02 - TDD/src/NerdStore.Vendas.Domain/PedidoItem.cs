using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Vendas.Domain
{
    public class PedidoItem
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }

        public PedidoItem(Guid productId, string productName, int quantidade, decimal valorUnitario)
        {
            ProductId = productId;
            ProductName = productName;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }
    }
}
