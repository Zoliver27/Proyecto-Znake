using Entidades_Znake;
using Datos_SQLConnection__Znake;
using System.Data;

namespace Logica_Znake
{
    public class LogicaAdmin
    {
        private readonly AdminTabla adminTabla = new AdminTabla();
        public string RegistrarAdministrador(Entidad_Administrador admin)
        {
            if (string.IsNullOrWhiteSpace(admin.nombre_Admin))
            {
                return "El nombre es obligatorio";
            }
            if (string.IsNullOrWhiteSpace(admin.email_Admin) || !admin.email_Admin.Contains("@"))
            {
                return "El email es obligatorio";
            }
            if (admin.edad_Admin < 18 || admin.edad_Admin > 90)
            {
                return "La edad debe estar en un rango valido (18-90)";
            }
            try
            {
                adminTabla.CrearValores(admin);
                return "OK";
            }
            catch (Exception ex)
            {
                return $"Error al registrar el administrador: {ex.Message}";
            }
        }
        public DataTable ObtenerValores()
        {
            return adminTabla.LeerValores();
        }
    }
}
