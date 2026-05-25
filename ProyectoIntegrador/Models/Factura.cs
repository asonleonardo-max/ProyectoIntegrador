using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Models
{
    internal class Factura
    {
        public string Id { get; set; }

        public Cotizacion Cotizacion { get; set; }

        public DateTime Fecha { get; set; }

        public bool Activa { get; set; }
    }
}
