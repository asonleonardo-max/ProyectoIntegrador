using ProyectoIntegrador.Models;
using ProyectoIntegrador.Repository;
using ProyectoIntegrador.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Controllers
{
    internal class TerrenoController
    {
        TerrenoRepository repository = new TerrenoRepository();
        CalculadoraVolumenService service = new CalculadoraVolumenService();

        public double CalcularVolumen(List<Coordenada> coordenadas)
        {
            return service.Calcular(coordenadas);
        }

        public void Guardar(Terreno terreno)
        {
            terreno.Id = Guid.NewGuid().ToString();
            terreno.FechaRegistro = DateTime.Now;
            repository.Guardar(terreno);
        }

        public List<Terreno> Leer()
        {
            return repository.Leer();
        }

        public void Eliminar(string id)
        {
            repository.Eliminar(id);
        }
    }
}
