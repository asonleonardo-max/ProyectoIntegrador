using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Models
{
    public class Cliente : Persona
    {
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Identificacion { get; set; }
    }
}

