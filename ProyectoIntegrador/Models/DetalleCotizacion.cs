using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Models
{
    internal class DetalleCotizacion
    {
        public string MaterialId { get; set; }
        public string NombreMaterial { get; set; }
        public double Cantidad { get; set; }
        public double Precio { get; set; }
        public double Subtotal { get; set; }
    }
}
