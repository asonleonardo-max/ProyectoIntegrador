using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Models
{
    internal class Cotizacion
    {
        public string Id { get; set; }

        public Cliente Cliente { get; set; }

        public Material Material { get; set; }

        public double Volumen { get; set; }

        public double Total { get; set; }

        public DateTime Fecha { get; set; }

        public bool Activa { get; set; }
    }
}
