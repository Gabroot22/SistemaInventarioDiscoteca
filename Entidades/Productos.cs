using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaInventarioDiscoteca.Entidades
{
    public class Productos
    {
        public int IdProducto { get; set; }
        public int IdCategoria { get; set; }
        public string NomProducto { get; set; }
        public int Stock { get; set; } /* de momento mientras se agrega la Entidad Inventarios*/
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }

        public CategoriaProductos? _CategoriaProducto { get; set; }
        public List<DetalleVentas> _DetalleVentas { get; set; }


    }
}
