using Microsoft.Data.SqlClient;
using System.Data;
using Entidades_Znake;

namespace Datos_SQLConnection__Znake
{
    public class AdminTabla
    {
        private readonly string connectionString = @"Server=SALSITAZU;Database=Znake_Prueba;User Id=sa;Password=132007;TrustServerCertificate=True;";
        public void CrearValores(Entidad_Administrador admin)
        {
            string query = @"INSERT INTO Administrador(Nombre, Email, Edad, Telefono)
                            VALUES (@Nombre, @Email, @Edad, @Telefono)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = admin.nombre_Admin;
                    command.Parameters.Add("@Email", SqlDbType.VarChar, 75).Value = admin.email_Admin;
                    command.Parameters.Add("@Edad", SqlDbType.Int).Value = admin.edad_Admin;
                    command.Parameters.Add("@Telefono", SqlDbType.VarChar, 15).Value = admin.telefono_Admin;
                    command.ExecuteNonQuery();
                }
            }
        }
        public DataTable LeerValores()
        {
            string query = @"SELECT ID_Administrador, Nombre, Email, Edad, Telefono FROM Administrador";
            DataTable tabla_Administrador = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter adaptador = new SqlDataAdapter(query, connection))
                {
                    adaptador.Fill(tabla_Administrador);
                }
            }
            return tabla_Administrador;
        }
    }
}