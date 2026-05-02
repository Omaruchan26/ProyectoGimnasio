namespace LibraryGym.nucleo
{
    public class Configuraciones
    {
        public static string obtener(string clave)
        {
            return "server=localhost\\DEV;database=GymDB;Integrated Security=True;TrustServerCertificate=true;";
        }
    }
}
