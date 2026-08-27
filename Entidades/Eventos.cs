using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaInventarioDiscoteca.Entidades
{
    public class Eventos
    {
        public int IdEvento { get; set; }
        public int IdEncargado { get; set; }
        public string DetalleEvento { get; set; }
        public DateTime FechaEvento { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }

        public Empleados? _Encargado { get; set; }
    }
}
