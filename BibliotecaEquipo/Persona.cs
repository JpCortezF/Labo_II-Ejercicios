using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEquipo
{
    public class Persona
    {
        long dni;
        string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(long dni, string nombre) : this(nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public long Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.Append($"DNI: {dni}");
            
            return sb.ToString();
        }
    }
}
