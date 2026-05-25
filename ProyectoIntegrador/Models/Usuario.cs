using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Models
{
    public class Usuario : Persona
    {
        public string NombreUsuario { get; set; }

        public string Password { get; set; }

        public string Rol { get; set; }

        public bool Activo { get; set; }
    }
}
