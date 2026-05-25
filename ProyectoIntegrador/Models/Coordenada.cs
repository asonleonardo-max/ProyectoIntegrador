using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Models
{
    internal class Coordenada
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Coordenada() { }

        // Constructor con parámetros — para crear coordenadas rápido
        public Coordenada(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Para mostrarla en la lista del formulario
        public override string ToString()
        {
            return "X: " + X.ToString() + " Y: " + Y.ToString() + " Z: " + Z.ToString();
        }
    }
}

