using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BakeryManager.Domain.Entities
{
    public class Cliente
    {
      public int Id { get; set; }
      public string Nombre { get; set; }
        public string Correo { get; set; }

        public string Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
