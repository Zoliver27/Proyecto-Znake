using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Znake;
using Logica_Znake;

namespace design_sign_up.Admin
{
    public partial class AddPro_Admin : Form
    {
        private readonly LogicaProducto _logicaProducto = new LogicaProducto();
        public AddPro_Admin()
        {
            InitializeComponent();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtbNombre.Text.Trim();
                string categoria = txtbCategoria.Text.Trim();
                string precioTexto = txtbPrecio.Text.Trim();
                string stockTexto = txtbStock.Text.Trim();

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("Debe ingresar el nombre del producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbNombre.Focus();
                    return;
                }

                if (!decimal.TryParse(precioTexto, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("Ingrese un precio válido mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbPrecio.Focus();
                    return;
                }

                if (!int.TryParse(stockTexto, out int stock) || stock < 0)
                {
                    MessageBox.Show("Ingrese una cantidad de stock válida (igual o mayor a 0).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbStock.Focus();
                    return;
                }

                Producto_Ent nuevoProducto = new Producto_Ent
                {
                    Nombre = nombre,
                    Categoria = string.IsNullOrWhiteSpace(categoria) ? null : categoria,
                    Precio = precio,
                    Stock = stock,
                    Id_Marca = 1,
                    Id_Proveedor = 1
                };

                btnAgregar.Enabled = false;

                await _logicaProducto.CrearAsync(nuevoProducto);

                MessageBox.Show("Producto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el producto: {ex.Message}", "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnAgregar.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbNombre.Clear();
            txtbCategoria.Clear();
            txtbPrecio.Clear();
            txtbStock.Clear();

            txtbNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
