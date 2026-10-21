using Entidades_Znake;
using Datos_SQLConnection__Znake;
using System.Data;

namespace Logica_Znake
{
    public class LogicaDueno
    {
        private readonly DuenoTabla duenoTabla = new DuenoTabla();
        public string RegistrarDueno(Entidad_Dueno dueno)
        {
            if (string.IsNullOrWhiteSpace(dueno.nombre_Dueno))
            {
                return "El nombre es obligatorio";
            }
            if (string.IsNullOrWhiteSpace(dueno.email_Dueno) || !dueno.email_Dueno.Contains("@"))
            {
                return "El email es obligatorio";
            }
            if (dueno.edad_Dueno < 18 || dueno.edad_Dueno > 90)
            {
                return "La edad debe estar en un rango valido (18-90)";
            }
            try
            {
                duenoTabla.CrearValores(dueno);
                return "OK";
            }
            catch (Exception ex)
            {
                return $"Error al registrar el dueño: {ex.Message}";
            }
        }
        public DataTable ObtenerValores()
        {
            return duenoTabla.LeerValores();
        }
    }
}
