using ProyectoIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Repository
{
    internal class CotizacionRepository
    {
        private static readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cotizaciones.json");

        JsonRepository<Cotizacion> repository = new JsonRepository<Cotizacion>(filePath);

        public List<Cotizacion> Leer()
        {
            return repository.Leer();
        }

        public void Guardar(List<Cotizacion> lista)
        {
            repository.Guardar(lista);
        }

        public void Actualizar(Cotizacion cotizacion)
        {
            List<Cotizacion> lista = Leer();
            int index = lista.FindIndex(m => m.Id == cotizacion.Id);
            if (index >= 0)
                lista[index] = cotizacion;
            repository.Guardar(lista);
        }

    }
}
