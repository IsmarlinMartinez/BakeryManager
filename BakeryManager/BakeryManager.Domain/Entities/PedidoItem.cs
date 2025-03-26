﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryManager.Domain.Entities
{
    public class PedidoItem
    {
        public int Id { get; set; } 
        public int Cantidad { get; set; }

        public decimal PrecioUnitario {  get; set; }

        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public int PedidoIdTotal { get; set; }
        public Producto Producto { get; set; }

    }
}
