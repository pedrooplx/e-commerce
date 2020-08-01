using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Repository
{
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext context) : base(context)
        {

        }
        public void UpdateQuantidade(ItemPedido itemPedido)
        {
            var itemDB = dbSet.Where(ip => ip.Id == itemPedido.Id).SingleOrDefault();

            if(itemDB != null)
            {
                context.SaveChanges();
            }
        }
    }
}
