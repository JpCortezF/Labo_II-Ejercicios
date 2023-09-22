using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class VehiculoTerrestre
    {
        short cantidadRuedas;
        short cantidadPuertas;
        EColor colores;
        

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, EColor colores)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.colores = colores;
        }

        public short CantidadRuedas { get => cantidadRuedas; set => cantidadRuedas = value; }
        public short CantidadPuertas { get => cantidadPuertas; set => cantidadPuertas = value; }
        public EColor Colores { get => colores; set => colores = value; }

        public virtual string MostrarVehiculoTerrestre()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"    Ruedas: {CantidadRuedas}");
            sb.AppendLine($"    Puertas: {CantidadPuertas}");
            sb.AppendLine($"    Color: {Colores}");           

            return sb.ToString();
        }
    }
}
