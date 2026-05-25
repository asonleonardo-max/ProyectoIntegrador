using ProyectoIntegrador.Models;
using ProyectoIntegrador.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Controllers
{
    internal class TerrenoController
    {
        CalculadoraVolumenService service = new CalculadoraVolumenService();

        public double CalcularVolumen(Terreno terreno)
        {
            return service.Calcular(terreno.Coordenadas);
        }
    }
}
