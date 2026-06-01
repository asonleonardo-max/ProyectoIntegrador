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
            if (coordenadas.Count < 3) return 0;

            // Límites del terreno
            double xMinimo = double.MaxValue, xMaximo = double.MinValue;
            double yMinimo = double.MaxValue, yMaximo = double.MinValue;

            foreach (Coordenada punto in coordenadas)
            {
                if (punto.X < xMinimo) xMinimo = punto.X;
                if (punto.X > xMaximo) xMaximo = punto.X;
                if (punto.Y < yMinimo) yMinimo = punto.Y;
                if (punto.Y > yMaximo) yMaximo = punto.Y;
            }

            // Tamaño de cada celda
            int numeroDivisiones = 50;
            double anchoCelda = (xMaximo - xMinimo) / numeroDivisiones;
            double altoCelda = (yMaximo - yMinimo) / numeroDivisiones;

            if (anchoCelda == 0 || altoCelda == 0) return 0;

            // Integral doble con regla del trapecio
            double volumenTotal = 0;

            for (int i = 0; i < numeroDivisiones; i++)
            {
                for (int j = 0; j < numeroDivisiones; j++)
                {
                    double x0 = xMinimo + i * anchoCelda;
                    double x1 = x0 + anchoCelda;
                    double y0 = yMinimo + j * altoCelda;
                    double y1 = y0 + altoCelda;

                    double alturaEsquina00 = InterpolarAltura(coordenadas, x0, y0);
                    double alturaEsquina10 = InterpolarAltura(coordenadas, x1, y0);
                    double alturaEsquina01 = InterpolarAltura(coordenadas, x0, y1);
                    double alturaEsquina11 = InterpolarAltura(coordenadas, x1, y1);

                    double alturaPromedioCelda = (alturaEsquina00 + alturaEsquina10 +
                                                  alturaEsquina01 + alturaEsquina11) / 4.0;

                    volumenTotal += alturaPromedioCelda * anchoCelda * altoCelda;
                }
            }

            return Math.Round(volumenTotal, 2);
        }

        private double InterpolarAltura(List<Coordenada> coordenadas, double x, double y)
        {
            double sumaPesos = 0;
            double sumaAlturasXPeso = 0;

            foreach (Coordenada punto in coordenadas)
            {
                double distancia = Math.Sqrt(
                    Math.Pow(punto.X - x, 2) + Math.Pow(punto.Y - y, 2));

                if (distancia < 0.0001) return punto.Z;

                double peso = 1.0 / (distancia * distancia);
                sumaPesos += peso;
                sumaAlturasXPeso += peso * punto.Z;
            }

            return sumaAlturasXPeso / sumaPesos;
        }
    }
}
