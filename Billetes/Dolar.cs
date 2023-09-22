namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        #region Contructores
        static Dolar()
        {
            cotzRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            Cantidad = cantidad;
        }

        #endregion

        #region Getters y Setters
        public double Cantidad { get => cantidad; set => cantidad = value; }
        public double CotzRespectoDolar { get => cotzRespectoDolar; set => cotzRespectoDolar = value; }

        #endregion

        #region explicit y/o implicit

        public static explicit operator Euro(Dolar dolar)
        {
            return new Euro(dolar.Cantidad * Euro.CotzRespectoDolar);
        }

        public static explicit operator Peso(Dolar dolar)
        {
            return new Peso(dolar.Cantidad * Peso.CotzRespectoDolar);
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static bool operator !=(Dolar dolar, Euro euro)
        {
            bool result = false;

            if(dolar.Cantidad != euro.Cantidad)
            {
                result = true;
            }
            return result;
        }
        public static bool operator ==(Dolar dolar, Euro euro)
        {
            return !(dolar != euro);
        }

        public static bool operator !=(Dolar dolar, Peso peso)
        {
            bool result = false;

            if (dolar.Cantidad != peso.Cantidad)
            {
                result = true;
            }
            return result;
        }
        public static bool operator ==(Dolar dolar, Peso peso)
        {
            return !(dolar != peso);
        }
        public static bool operator !=(Dolar dolar, Dolar dolar2)
        {
            bool result = false;

            if (dolar.Cantidad != dolar2.Cantidad)
            {
                result = true;
            }
            return result;
        }
        public static bool operator ==(Dolar dolar, Dolar dolar2)
        {
            return !(dolar != dolar2);
        }
        public static Dolar operator -(Dolar dolar, Euro euro)
        {
            return new Dolar(dolar.Cantidad - ((Dolar)euro).Cantidad);
        }
        public static Dolar operator +(Dolar dolar, Euro euro)
        {
            return new Dolar(dolar.Cantidad + ((Dolar)euro).Cantidad);
        }
        public static Dolar operator -(Dolar dolar, Peso peso)
        {
            return new Dolar(dolar.Cantidad - ((Dolar)peso).Cantidad);
        }
        public static Dolar operator +(Dolar dolar, Peso peso)
        {
            return new Dolar(dolar.Cantidad + ((Dolar)peso).Cantidad);
        }

        #endregion

    }
}