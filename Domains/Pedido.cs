using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DbSetPedidos.Domains;

namespace DbSetPedidos.Domains
{
    public class Pedido : BaseDomain
    {

        public string Status { get; set; }
        public DateTime OrderDate { get; set; }

         public List<PedidoItem> PedidosItens { get; set; }

         public Pedido()
         {
             PedidosItens = new List<PedidoItem>();
         }
    }
}