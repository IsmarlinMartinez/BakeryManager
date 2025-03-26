using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryManager.Domain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public decimal? Total { get; set; }


        public int ClienteId {  get; set; }
        public Cliente Cliente { get; set; }
        public List<PedidoItem> PedidoItems { get; set; }   


    }
}
