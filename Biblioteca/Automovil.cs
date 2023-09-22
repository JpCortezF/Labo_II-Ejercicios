using System.Drawing;
using System.Text;

namespace Biblioteca
{
    public class Automovil : VehiculoTerrestre
    {
        int cantidadPasajeros;
        short cantidadMarchas;

        public Automovil(short cantidadRuedas, short cantidadPuertas, EColor colores, short cantidadMarchas, int cantidadPasajeros)
            : base(cantidadRuedas, cantidadPuertas, colores)
        {
            this.cantidadPasajeros = cantidadPasajeros;
            this.cantidadMarchas = cantidadMarchas; 
        }
        public int CantidadPasajeros { get => cantidadPasajeros; set => cantidadPasajeros = value; }
        public short CantidadMarchas { get => cantidadMarchas; set => cantidadMarchas = value; }

        public override string MostrarVehiculoTerrestre()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"    Pasajeros: {CantidadPasajeros}");
            sb.AppendLine($"    Cantidad Marchas: {CantidadMarchas}");
            sb.Append(base.MostrarVehiculoTerrestre());
            return sb.ToString();
        }
    }
}