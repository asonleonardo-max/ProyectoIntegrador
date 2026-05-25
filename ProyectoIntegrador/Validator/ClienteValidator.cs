using ProyectoIntegrador.Models;
using System;
using System.Collections.Generic;

namespace ProyectoIntegrador.Validator
{
    internal class ClienteValidator
    {
        public static string Validar(Cliente cliente, List<Cliente> listaExistente)
        {
            if (cliente.Nombre == "")
                return "El nombre es obligatorio";

            if (cliente.Identificacion == "")
                return "La identificación es obligatoria";

            if (cliente.Telefono == "")
                return "El teléfono es obligatorio";

            if (cliente.Correo == "")
                return "El correo es obligatorio";

            // Verifica si ya existe un cliente con la misma identificación
            // pero que no sea el mismo
            Cliente? duplicado = listaExistente.Find(clienteExistente =>
            clienteExistente.Identificacion == cliente.Identificacion &&
            clienteExistente.Id != cliente.Id);

            if (duplicado != null)
                return "Ya existe un cliente con esa identificación";

            return String.Empty;
        }
    }
}