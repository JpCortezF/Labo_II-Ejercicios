using System.Text;

namespace BibliotecaEquipo
{
    public class DirectorTecnico : Persona
    {
        DateTime fechaDeNacimiento;

        public DirectorTecnico(string nombre) : base(nombre)
        {
            
        }
        public DirectorTecnico(long dni, string nombre) : base(dni, nombre)
        {

        }
        public DirectorTecnico(string nombre, DateTime fechaDeNacimiento) : base(nombre)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public override string MostrarDatos() 
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Fecha de nac. {fechaDeNacimiento.ToString("dd/MM/yyyy")}");
            
            return sb.ToString();
        }
        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            bool ret = false;
            if (dt1.Nombre == dt2.Nombre && dt1.fechaDeNacimiento == dt2.fechaDeNacimiento)
            {
                ret = true;
            }
            return ret;
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}