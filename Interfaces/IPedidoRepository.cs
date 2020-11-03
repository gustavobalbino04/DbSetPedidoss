using System.Collections.Generic;
using DbSetPedidos.Domains;

namespace DbSetPedidos.Interfaces
{
    public interface IPedidoRepository
    {
        List<Pedido> Listar();

         Pedido Adicionar(List<PedidoItem> _pedidosItens);
         
    }
}