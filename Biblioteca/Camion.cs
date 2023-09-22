using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Camion : VehiculoTerrestre
    {
        int pesoCarga;
        short cantidadMarchas;

        public Camion(short cantidadRuedas, short cantidadPuertas, EColor colores, short cantidadMarchas, int pesoCarga)
            : base(cantidadRuedas, cantidadPuertas, colores)
        {
            this.pesoCarga = pesoCarga;
            this.cantidadMarchas = cantidadMarchas;
        }
        public int PesoCarga { get => pesoCarga; set => pesoCarga = value; }
        public short CantidadMarchas { get => cantidadMarchas; set => cantidadMarchas = value; }

        public override string MostrarVehiculoTerrestre()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"    Peso carga: {PesoCarga}");
            sb.AppendLine($"    Cantidad marchas: {CantidadMarchas}");
            sb.Append(base.MostrarVehiculoTerrestre());
            return sb.ToString();
        }
    }
}
