using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroContactosApp.Clases
{
    internal class Datos
    {
        public string nombre {  get; set; }
        public string numero { get; set; }
        public string correo { get; set; }

        public Datos(string nombre, string numero, string correo)
        { 
            this.nombre = nombre;
            this.numero = numero;
            this.correo = correo;
        }

        public override string ToString()
        {
            return $"{nombre} - {numero} - {correo}";
        }

    }
}
