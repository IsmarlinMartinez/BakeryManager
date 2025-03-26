using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryManager.Domain.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public string Ingredientes { get; set; }

        public int CategoriaId { get; set; }

        public Categoria categoria { get; set; }
    public List<PedidoItem> PedidoItems { get; set; }
        public List<RecetaIngrediente> RecetaIngredientes { get; set; }

    }
}
