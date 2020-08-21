using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models
{
    //MELHORIA: 5) arquivo modelo.cs foi quebrado em v�rios arquivos
    //veja o diagrama
    public class Pedido : BaseModel
    {
        public Pedido(string clienteId)
        {
            Cadastro = new Cadastro();
            ClienteId = clienteId;
        }

        public Pedido(Cadastro cadastro, string clienteId)
        {
            Cadastro = cadastro;
            ClienteId = clienteId;
        }

        public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();

        [ForeignKey("CadastroId")]
        public int CadastroId { get; set; }
        [Required]
        public virtual Cadastro Cadastro { get; private set; }

        //Adicionar Id do cliente ao pedido
        [Required]
        public string ClienteId { get; set; }
    }
}
