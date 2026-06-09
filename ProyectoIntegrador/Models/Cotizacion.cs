using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Models
{
    internal class Cotizacion
    {
        public string Id { get; set; }
        public string ClienteId { get; set; }
        public string ClienteNombre { get; set; }
        public List<DetalleCotizacion> Detalles { get; set; } = new List<DetalleCotizacion>();
        public double Subtotal { get; set; }
        public double IVA { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activa { get; set; }
        public string Observacion { get; set; }
    }
}
