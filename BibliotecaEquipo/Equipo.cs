using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEquipo
{
    public class Equipo
    {
        short cantidadJugadores;
        List<Jugador> jugadores;
        string nombre;

        public Equipo()
        {
            cantidadJugadores = 0;
            jugadores = new List<Jugador>();
            nombre = string.Empty;  
        }

        public Equipo(short cantidadJugadores, string nombre) : this()
        {
            this.cantidadJugadores = cantidadJugadores;
            this.nombre = nombre;
        }
        public short CantidadJugadores { get => cantidadJugadores; set => cantidadJugadores = value; }
        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool agrega = false;
            if(e != null && e.jugadores != null)
            {
                e.Jugadores.Add(j);
                agrega = true;            
            }
            return agrega;
        }
    }
}
