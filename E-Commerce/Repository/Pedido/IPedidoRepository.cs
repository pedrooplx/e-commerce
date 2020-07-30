using E_Commerce.Models;
using System.Collections.Generic;

namespace E_Commerce.Repository
{
    public interface IPedidoRepository
    {
        Pedido GetPedido();
        void AddItem(string codigo);
    }
}