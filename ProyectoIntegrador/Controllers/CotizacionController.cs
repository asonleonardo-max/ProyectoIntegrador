using ProyectoIntegrador.Models;
using ProyectoIntegrador.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Controllers
{
    internal class CotizacionController
    {
        CotizacionRepository repository = new CotizacionRepository();

        public List<Cotizacion> Leer()
        {
            return repository.Leer();
        }

        public void Guardar(Cotizacion cotizacion)
        {
            cotizacion.Id = Guid.NewGuid().ToString();
            List<Cotizacion> lista = repository.Leer();
            lista.Add(cotizacion);
            repository.Guardar(lista);
        }

        public void CambiarEstado(string id)
        {
            List<Cotizacion> lista = repository.Leer();
            Cotizacion c = lista.Find(x => x.Id == id);
            if (c != null)
            {
                c.Activa = !c.Activa;
                repository.Guardar(lista);
            }
        }

        public void Actualizar(Cotizacion cotizacion)
        {
            repository.Actualizar(cotizacion);
        }

        public void Eliminar(string id)
        {
            List<Cotizacion> lista = repository.Leer();
            lista.RemoveAll(x => x.Id == id);
            repository.Guardar(lista);
        }

    }
}
