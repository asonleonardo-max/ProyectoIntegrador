using ProyectoIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Repository
{
    internal class FacturaRepository
    {
        private static readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "facturas.json");

        JsonRepository<Factura> repository = new JsonRepository<Factura>(filePath);

        public List<Factura> Leer()
        {
            return repository.Leer();
        }

        public void Guardar(List<Factura> lista)
        {
            repository.Guardar(lista);
        }
    }
}
