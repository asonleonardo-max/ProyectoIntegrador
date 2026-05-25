using ProyectoIntegrador.Models;
using ProyectoIntegrador.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Controllers
{
    internal class ClienteController
    {
        ClienteRepository repository = new ClienteRepository();

        public List<Cliente> Leer()
        {
            return repository.Leer();
        }

        public void Guardar(Cliente cliente)
        {
            List<Cliente> lista = repository.Leer();

            Cliente existente = lista.Find(clienteBuscado => clienteBuscado.Id == cliente.Id);

            if (existente == null)
            {
                lista.Add(cliente);
            }
            else
            {
                existente.Nombre = cliente.Nombre;
                existente.Identificacion = cliente.Identificacion;
                existente.Telefono = cliente.Telefono;
                existente.Correo = cliente.Correo;
            }

            repository.Guardar(lista);
        }

        public void Eliminar(string id)
        {
            List<Cliente> lista = repository.Leer();

            Cliente cliente = lista.Find(clienteBuscado => clienteBuscado.Id == id);

            if (cliente != null)
            {
                lista.Remove(cliente);

                repository.Guardar(lista);
            }
        }
    }
}

