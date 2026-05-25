using ProyectoIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Services
{
    internal class CalculadoraVolumenService
    {
        public double Calcular(List<Coordenada> coordenadas)
        {
            if (coordenadas.Count == 0)
            {
                return 0;
            }

            double sumaAlturas = 0;

            foreach (Coordenada coordenada in coordenadas)
            {
                sumaAlturas = sumaAlturas + coordenada.Z;
            }

            double alturaPromedio = sumaAlturas / coordenadas.Count;

            double area = coordenadas.Count * 10;

            double volumen =  area * alturaPromedio;

            return volumen;
        }
    }
}
