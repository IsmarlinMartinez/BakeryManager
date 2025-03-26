using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryManager.Domain.Entities
{
    public class RecetaIngrediente
    {
        public int Id { get; set; }
        public decimal Cantidad {  get; set; }
        public string UnidadMedida  { get; set; }


        public int RecetaId {  get; set; }
        public Receta Receta { get; set; }
        public int ProductoId {  get; set; }
        public Producto Producto { get; set; }
    }
}
