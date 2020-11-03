using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DbSetPedidos.Contexts;
using DbSetPedidos.Domains;
using DbSetPedidos.Interfaces;
using System.Threading.Tasks;

namespace DbSetPedidos.Repositories
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
        [ApiController]
    public class PedidoItemRepository : IPedidoItemRepository
    {
         private readonly PedidoContext _ctx;
        public PedidoItemRepository()
        {
            _ctx = new PedidoContext();
        }
        public void Adicionar(PedidoItem pedidoItens)
        {
            try{
            
            _ctx.PedidoItems.Add(pedidoItens);
          
            _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Produto Adicionar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public PedidoItem BuscarPorId(Guid id)
        {
             try
            {
               return _ctx.PedidoItems.FirstOrDefault(x => x.Id == id);          
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public List<Produto> BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public Produto Editar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public List<PedidoItem> Listar()
        {
             try
            {
                List<PedidoItem> pitens = _ctx.PedidoItems.ToList();
                return pitens;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public void Remover(Guid id)
        {
             try
            {
                PedidoItem pedidoIT = BuscarPorId(id);
                if(pedidoIT == null)
                throw new Exception("Pedido Item não encontrado  ");

                _ctx.PedidoItems.Remove(pedidoIT);
                _ctx.SaveChanges();
                
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

       
    }
}