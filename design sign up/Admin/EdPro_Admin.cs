using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Znake;
using Logica_Znake;

namespace design_sign_up.Admin
{
    public partial class EdPro_Admin : Form
    {
        private readonly LogicaProducto _logicaProducto = new LogicaProducto();
        private readonly int _idProducto;
        private Producto_Ent _productoActual;
        public EdPro_Admin(int idProducto)
        {
            InitializeComponent();
            _idProducto = idProducto;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtbNombre.Text.Trim();
                string categoria = txtbCategoria.Text.Trim();

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El nombre del producto no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtbPrecio.Text.Trim(), out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("Ingrese un precio válido mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtbStock.Text.Trim(), out int stock) || stock < 0)
                {
                    MessageBox.Show("Ingrese un stock válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _productoActual.Nombre = nombre;
                _productoActual.Categoria = string.IsNullOrWhiteSpace(categoria) ? null : categoria;
                _productoActual.Precio = precio;
                _productoActual.Stock = stock;

                // Guardar en la base de datos
                await _logicaProducto.ActualizarAsync(_productoActual);

                MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async void EdPro_Admin_Load(object sender, EventArgs e)
        {
            await CargarDatosProductoAsync();
        }
        private async Task CargarDatosProductoAsync()
        {
            try
            {
                _productoActual = await _logicaProducto.ObtenerPorIdAsync(_idProducto);

                if (_productoActual != null)
                {
                    txtbNombre.Text = _productoActual.Nombre;
                    txtbCategoria.Text = _productoActual.Categoria;
                    txtbPrecio.Text = _productoActual.Precio.ToString("0.00");
                    txtbStock.Text = _productoActual.Stock.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró el producto en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los datos del producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
