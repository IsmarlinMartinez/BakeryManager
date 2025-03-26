using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryManager.Domain.Entities
{
    public class Receta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TiempoPreparacion { get; set; }
        public string Pasos {  get; set; }
        public string Rendimiento { get; set; }
        public List<RecetaIngrediente> Ingredientes { get; set; }

    }
}
