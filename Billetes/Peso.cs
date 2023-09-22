using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        #region Contructores
        static Peso()
        {
            CotzRespectoDolar = 102.65;
        }
        public Peso(double cantidad)
        {
            Cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            CotzRespectoDolar = cotizacion;
        }
        #endregion

        #region Getters y Setters
        public double Cantidad { get => cantidad; set => cantidad = value; }
        public static double CotzRespectoDolar { get => cotzRespectoDolar; set => cotzRespectoDolar = value; }

        #endregion

        #region explicit y/o implicit

        public static explicit operator Dolar(Peso peso)
        {
            return new Dolar(peso.Cantidad / Peso.CotzRespectoDolar);
        }
        public static explicit operator Euro(Peso peso)
        {
            return (Euro)((Dolar)(peso)); // convierto el peso a dolar.
        }

        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        public static bool operator!=(Peso peso, Dolar dolar)
        {
            bool result = false;

            if(peso.Cantidad != dolar.Cantidad)
            {
                result = true;
            }
            return result;
        }
        public static bool operator ==(Peso peso, Dolar dolar)
        {
            return !(peso != dolar);
        }

        public static bool operator !=(Peso peso, Euro euro)
        {
            bool result = false;

            if (peso.Cantidad != euro.Cantidad)
            {
                result = true;
            }
            return result;
        }
        public static bool operator ==(Peso peso, Euro euro)
        {
            return !(peso != euro);
        }

        public static bool operator !=(Peso peso, Peso peso2)
        {
            bool result = false;

            if (peso.Cantidad != peso2.Cantidad)
            {
                result = true;
            }
            return result;
        }
        public static bool operator ==(Peso peso, Peso peso2)
        {
            return !(peso != peso2);
        }
        
        public static Peso operator -(Peso peso, Dolar dolar)
        {
            return (peso.Cantidad - ((Peso)dolar).Cantidad);
        }
        public static Peso operator +(Peso peso, Dolar dolar)
        {
            return (peso.Cantidad + ((Peso)dolar).Cantidad);
        }
        public static Peso operator -(Peso peso, Euro euro)
        {
            return (peso.Cantidad - ((Peso)euro).Cantidad);
        }
        public static Peso operator +(Peso peso, Euro euro)
        {
            return (peso.Cantidad + ((Peso)euro).Cantidad);
        }
        #endregion
    }
}
