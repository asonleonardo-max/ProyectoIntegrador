using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Models
{
    internal class Terreno
    {
        public string Id { get; set; }

        public List<Coordenada> Coordenadas { get; set; }

        public double VolumenCalculado { get; set; }
    }
}
