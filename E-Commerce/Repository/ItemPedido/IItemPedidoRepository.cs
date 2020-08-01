using E_Commerce.Models;

namespace E_Commerce.Repository
{
    public interface IItemPedidoRepository
    {
        void UpdateQuantidade(ItemPedido itemPedido);
    }
}