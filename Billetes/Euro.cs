using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        #region Contructores
        static Euro()
        {
            CotzRespectoDolar = 1/1.17;
        }
        public Euro(double cantidad)
        {
            Cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion):this(cantidad)
        {
            CotzRespectoDolar = cotizacion;
        }
        #endregion

        #region Getters y Setters
        public double Cantidad { get => cantidad; set => cantidad = value; }
        public static double CotzRespectoDolar { get => cotzRespectoDolar; set => cotzRespectoDolar = value; }


        #endregion

        #region explicit y/o implicit
        public static explicit operator Dolar(Euro euro)
        {
            return new Dolar(euro.Cantidad / Euro.cotzRespectoDolar);
        }
        public static explicit operator Peso(Euro euro)
        {
            return (Peso)((Dolar)euro);
        }
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }
        public static bool operator !=(Euro euro, Dolar dolar)
        {
            bool result = false;
            if (euro.Cantidad != dolar.Cantidad)
            {
                result = true;
            }
            return result;
        }
        public static bool operator ==(Euro euro, Dolar dolar)
        {
            return !(euro != dolar);
        }
        public static bool operator !=(Euro euro, Peso peso)
        {
            bool result = false;
            if (euro.Cantidad != peso.Cantidad)
            {
                result = true;
            }
            return result;
        }
        public static bool operator ==(Euro euro, Peso peso)
        {
            return !(euro != peso);
        }
        public static bool operator !=(Euro euro, Euro euro2)
        {
            bool result = false;
            if (euro.Cantidad != euro2.Cantidad)
            {
                result = true;
            }
            return result;
        }
        public static bool operator ==(Euro euro, Euro euro2)
        {
            return !(euro != euro2);
        }
        public static Euro operator -(Euro euro, Dolar dolar)
        {
            return new Euro(euro.Cantidad - ((Euro)dolar).Cantidad);
        }
        public static Euro operator +(Euro euro, Dolar dolar)
        {
            return new Euro(euro.Cantidad + ((Euro)dolar).Cantidad);
        }
        public static Euro operator -(Euro euro, Peso peso)
        {
            return new Euro(euro.Cantidad - ((Euro)peso).Cantidad);
        }
        public static Euro operator +(Euro euro, Peso peso)
        {
            return new Euro(euro.Cantidad + ((Euro)peso).Cantidad);
        }
        #endregion
    }
}
