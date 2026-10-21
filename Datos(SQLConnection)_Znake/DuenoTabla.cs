using Entidades_Znake;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Datos_SQLConnection__Znake
{
    public class DuenoTabla
    {
        private readonly string conexionString = @"Server=SALSITAZU;Database=Znake_Prueba;User Id=sa;Password=132007;TrustServerCertificate=True;";
        public void CrearValores(Entidad_Dueno dueno)
        {
            string query = @"INSERT INTO Dueno(Nombre, Email, Edad, Telefono)
                            VALUES (@Nombre, @Email, @Edad, @Telefono)";
            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = dueno.nombre_Dueno;
                    command.Parameters.Add("@Email", SqlDbType.VarChar, 75).Value = dueno.email_Dueno;
                    command.Parameters.Add("@Edad", SqlDbType.Int).Value = dueno.edad_Dueno;
                    command.Parameters.Add("@Telefono", SqlDbType.VarChar, 15).Value = dueno.telefono_Dueno;
                    command.ExecuteNonQuery();
                }
            }
        }
        public DataTable LeerValores()
        {
            string query = @"SELECT ID_Dueno, Nombre, Email, Edad, Telefono FROM Dueno";
            DataTable tabla_Dueno = new DataTable();
            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                connection.Open();
                using (SqlDataAdapter adaptador = new SqlDataAdapter(query, connection))
                {
                    adaptador.Fill(tabla_Dueno);
                }
            }
            return tabla_Dueno;
        }
    }
}