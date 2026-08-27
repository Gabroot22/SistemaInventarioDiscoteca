using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaInventarioDiscoteca.Entidades
{
    public class ElementosInternos
    {
        public int IdElementoInterno { get; set; }
        public string NombreElementoInterno { get; set; }
        public int CantidadElementoInterno { get; set; }
        public decimal PrecioElementoInterno { get; set; }

        public List <DetalleReparaciones> _DetalleReparaciones { get; set; }
    }
}
