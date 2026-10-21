using Logica_Znake;
using Entidades_Znake;

namespace design_sign_up
{
    public partial class Gestion_Privada : Form
    {
        private readonly LogicaDueno logicaDueno = new LogicaDueno();
        private readonly LogicaAdmin logicaAdmin = new LogicaAdmin();
        private void ConfigurarDgvDueno()
        {
            dgv_GestionDueno.Columns.Clear();

            dgv_GestionDueno.ReadOnly = true;
            dgv_GestionDueno.AllowUserToAddRows = false;
            dgv_GestionDueno.RowHeadersVisible = false;

        }
        private void ConfigurarDgvAdmin()
        {
            dgv_GestionAdministrador.Columns.Clear();
            
            dgv_GestionAdministrador.ReadOnly = true;
            dgv_GestionAdministrador.AllowUserToAddRows = false;
            dgv_GestionAdministrador.RowHeadersVisible = false;

        }
        private void CargarTabla()
        {
            try
            {
                dgv_GestionDueno.DataSource = logicaDueno.ObtenerValores();
                dgv_GestionAdministrador.DataSource = logicaAdmin.ObtenerValores();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los valores: {ex.Message}");
            }
            if (dgv_GestionDueno.Columns["ID_Dueno"] != null)
            {
                dgv_GestionDueno.Columns["ID_Dueno"].HeaderText = "ID";
            }
            if (dgv_GestionAdministrador.Columns["ID_Administrador"] != null)
            {
                dgv_GestionAdministrador.Columns["ID_Administrador"].HeaderText = "ID";
            }
        }

        public Gestion_Privada()
        {
            InitializeComponent();
            ConfigurarDgvDueno();
            ConfigurarDgvAdmin();
            CargarTabla();
        }
        private void btn_RegistrarGPriv_Click(object sender, EventArgs e)
        {
            if (cmb_PuestosT.Text == "Dueno")
            {
                int.TryParse(txb_Edad.Text, out int edad);

                Entidad_Dueno nuevoDueno = new Entidad_Dueno
                {
                    nombre_Dueno = txb_Nombre.Text.Trim(),
                    email_Dueno = txb_Email.Text.Trim(),
                    edad_Dueno = edad,
                    telefono_Dueno = txb_Telefono.Text.Trim()
                };

                string resultado = logicaDueno.RegistrarDueno(nuevoDueno);

                if (resultado == "OK")
                {
                    MessageBox.Show("Registro exitoso");
                    CargarTabla();
                }
                else
                {
                    MessageBox.Show($"Error: {resultado}");
                }
            }
            if (cmb_PuestosT.Text == "Administrador")
            {
                int.TryParse(txb_Edad.Text, out int edad);

                Entidad_Administrador nuevoAdmin = new Entidad_Administrador
                {
                    nombre_Admin = txb_Nombre.Text.Trim(),
                    email_Admin = txb_Email.Text.Trim(),
                    edad_Admin = edad,
                    telefono_Admin = txb_Telefono.Text.Trim()
                };

                string resultado = logicaAdmin.RegistrarAdministrador(nuevoAdmin);

                if (resultado == "OK")
                {
                    MessageBox.Show("Registro Exitoso");
                    CargarTabla();
                }
                else
                {
                    MessageBox.Show($"Error: {resultado}");
                }
            }
        }

        private void Gestion_Privada_Load(object sender, EventArgs e)
        {

        }
    }
}
