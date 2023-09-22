namespace LibrarySumador
{
    public class Sumador
    {
        private int cantidadSumas;

        #region Constructores
        public Sumador() : this(0)
        {

        }
        public Sumador(int cantidadSumas)
        {
            this.CantidadSumas = cantidadSumas;
        }

        #endregion

        public int CantidadSumas { get => cantidadSumas; set => cantidadSumas = value; }

        #region Metodo Sumar
        public long Sumar(long a, long b)
        {
            this.CantidadSumas++;

            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.CantidadSumas++;

            return a + " " + b;
        }

        #endregion

        public static explicit operator int(Sumador sumador)
        {
            return sumador.CantidadSumas;
        }
        public static long operator +(Sumador sumador, Sumador sumador2)
        {            
            return sumador.CantidadSumas + sumador2.CantidadSumas;
        }
        public static bool operator |(Sumador sumador, Sumador sumador2)
        {
            bool result = false;
            if(sumador.CantidadSumas == sumador2.CantidadSumas)
            {
                result = true;
            }
            return result;
        }
    }
}