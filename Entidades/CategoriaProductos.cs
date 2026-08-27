using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaInventarioDiscoteca.Entidades
{
    public class CategoriaProductos
    {
        public int IdCategoria { get; set; }
        public string NomCategoria { get; set; }

        public List<Productos> _Productos { get; set; }
    }
}
