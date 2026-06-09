using ProyectoIntegrador.Models;
using ProyectoIntegrador.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Controllers
{
    internal class FacturaController
    {
        FacturaRepository repository = new FacturaRepository();

        public List<Factura> Leer()
        {
            return repository.Leer();
        }

        public void CrearDesdeCotizacion(Cotizacion cotizacion)
        {
            List<Factura> lista = repository.Leer();

            bool yaFacturada = lista.Any(f => f.Cotizacion.Id == cotizacion.Id);
            if (yaFacturada)
                throw new InvalidOperationException("Esta cotización ya fue convertida en factura.");

            int numero = lista.Count > 0 ? lista.Max(f => f.NumeroFactura) + 1 : 1;

            Factura factura = new Factura
            {
                Id = Guid.NewGuid().ToString(),
                NumeroFactura = numero,
                Cotizacion = cotizacion,
                Fecha = DateTime.Now,
                Activa = true
            };

            lista.Add(factura);
            repository.Guardar(lista);
        }

        public void CambiarEstado(string id)
        {
            List<Factura> lista = repository.Leer();
            Factura f = lista.Find(x => x.Id == id);
            if (f != null)
            {
                f.Activa = !f.Activa;
                repository.Guardar(lista);
            }
        }

        public void Eliminar(string id)
        {
            List<Factura> lista = repository.Leer();
            lista.RemoveAll(x => x.Id == id);
            repository.Guardar(lista);
        }

        public List<Factura> Filtrar(string cliente = "", DateTime? fecha = null, bool? activa = null)
        {
            List<Factura> lista = repository.Leer();

            if (!string.IsNullOrWhiteSpace(cliente))
                lista = lista.Where(f => f.Cotizacion.ClienteNombre.Contains(cliente, StringComparison.OrdinalIgnoreCase)).ToList();

            if (fecha.HasValue)
                lista = lista.Where(f => f.Fecha.Date == fecha.Value.Date).ToList();

            if (activa.HasValue)
                lista = lista.Where(f => f.Activa == activa.Value).ToList();

            return lista;
        }
    }
}
