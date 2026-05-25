using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Models
{
    internal class Terreno
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string ClienteId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public double VolumenCalculado { get; set; }
        public List<Coordenada> Coordenadas { get; set; }

        // Constructor vacío — necesario para leer el JSON
        public Terreno()
        {
            Coordenadas = new List<Coordenada>();
        }
    }
}

