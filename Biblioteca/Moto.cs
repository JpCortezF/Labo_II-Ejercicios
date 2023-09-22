using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Moto : VehiculoTerrestre
    {
        short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, EColor colores, short cilindrada)
            : base(cantidadRuedas, cantidadPuertas, colores)
        {
            this.cilindrada = cilindrada;
        }

        public short Cilindrada { get => cilindrada; set => cilindrada = value; }

        public override string MostrarVehiculoTerrestre()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"    Cilindrada: {Cilindrada}");
            sb.Append(base.MostrarVehiculoTerrestre());
            return sb.ToString();
        }
    }
}
