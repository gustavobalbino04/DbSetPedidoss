using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DbSetPedidos.Domains;
using DbSetPedidos.Interfaces;
using DbSetPedidos.Repositories;

namespace DbSetPedidos.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class PedidosController
    {
          private readonly IPedidoRepository _pedidoRepository;
        
    public  PedidosController()
    {
        _pedidoRepository = new PedidoRepository();
    }
    /// <summary>
         /// Ler todos os pedidos cadastrados
        /// </summary>
        /// <returns>Lista de pedidos</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var pedidos = _pedidoRepository.Listar();

                if (pedidos.Count == 0)
                    return NoContent();

                return Ok(pedidos);
                
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);

            }
        }
       [HttpPost]
       public IActionResult Post(List<PedidoItem> pedidosItems)
        {
            try
            {

                Pedido pedidos = _pedidoRepository.Adicionar(pedidosItems);

                return Ok(pedidos);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}