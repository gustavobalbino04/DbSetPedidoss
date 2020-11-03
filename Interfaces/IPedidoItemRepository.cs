using System;
using System.Collections.Generic;
using DbSetPedidos.Domains;

namespace DbSetPedidos.Interfaces
{
    public interface IPedidoItemRepository
    {
        List<PedidoItem> Listar();
         
         PedidoItem BuscarPorId(Guid id);
         void Adicionar(PedidoItem pedidoItens);
         void Remover(Guid id);
    }
}