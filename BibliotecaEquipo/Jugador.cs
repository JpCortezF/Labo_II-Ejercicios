using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEquipo
{
    public class Jugador : Persona
    {
        int partidosJugados;
        int totalGoles;


        public Jugador(long dni, string nombre) : base(dni, nombre)
        {

        }
        public Jugador(long dni, string nombre, int partidosJugados, int totalGoles) : base(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public int PartidosJugados { get => partidosJugados; set => partidosJugados = value; }
        public int TotalGoles { get => totalGoles; set => totalGoles = value; }
        public float PromedioDeGoles { get => (totalGoles / (float)partidosJugados); }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Part. Jugados: {partidosJugados}");
            sb.AppendLine($"Total Goles: {totalGoles}");
            sb.AppendLine($"Prom Goles: {PromedioDeGoles:F2}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool result = false;
            if (j1.Nombre == j2.Nombre && j1.Dni == j2.Dni)
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
