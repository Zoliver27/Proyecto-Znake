using design_sign_up.Admin;
using Logica_Znake;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace design_sign_up
{
    public partial class MenuAdmin : Form
    {
        //---Para el apartado de inicio---
        private readonly LogicaVenta _logicaVenta = new LogicaVenta();
        private readonly LogicaCliente _logicaCliente = new LogicaCliente();
        private readonly LogicaProducto _logicaProducto = new LogicaProducto();
        //---Estara Disponible Para todos los Roles---
        private void Cambiar_Panel()
        {
            pnl_Inicio.Visible = false;
            pnl_Productos.Visible = false;
            pnl_Clientes.Visible = false;
            pnl_Ventas.Visible = false;
            pnl_Inventario.Visible = false;
            pnl_Configuracion.Visible = false;
        }

        public MenuAdmin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            Cambiar_Panel();
            pnl_Productos.Visible = true;
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            Cambiar_Panel();
            pnl_Inicio.Visible = true;
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            Cambiar_Panel();
            pnl_Clientes.Visible = true;
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            Cambiar_Panel();
            pnl_Ventas.Visible = true;
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            Cambiar_Panel();
            pnl_Inventario.Visible = true;
        }

        private void btn_Configuracion_Click(object sender, EventArgs e)
        {
            Cambiar_Panel();
            pnl_Configuracion.Visible = true;
        }
        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            Sign_In SI = new Sign_In();
            SI.Show();
            this.Close();
        }


        private async void Menu_Load(object sender, EventArgs e)
        {
            await CargarMetricasAsync();
            await CargarProductosAsync();
        }
        public async Task CargarMetricasAsync() //---Para el boton de Inicio---
        {
            try
            {
                var ventas = await _logicaVenta.ObtenerTodosAsync();
                var clientes = await _logicaCliente.ObtenerTodosAsync();
                var productos = await _logicaProducto.ObtenerTodosAsync();

                decimal totalIngresos = ventas?.Sum(v => v.Total) ?? 0;
                int totalClientes = clientes?.Count() ?? 0;
                int totalProductos = productos?.Count() ?? 0;
                int totalVentas = ventas?.Count() ?? 0;

                lblTotalIngresos.Text = $"{totalIngresos:C2}";
                lblTotalClientes.Text = totalClientes.ToString("N0");
                lblTotalProductos.Text = totalProductos.ToString("N0");
                lblTotalVentas.Text = totalVentas.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las métricas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnAgregarNuevoProducto_Click(object sender, EventArgs e) //Aqui abre un forms para la edicion sobre el anadimiento de un poroducto nuevo
        {
            using (AddPro_Admin AP = new AddPro_Admin())
            {
                if (AP.ShowDialog() == DialogResult.OK)
                {
                    await CargarProductosAsync();
                }
            }
        }
        private async Task CargarProductosAsync(string filtro = "")
        {
            try
            {
                var productos = await _logicaProducto.ObtenerTodosAsync();

                if (productos != null)
                {
                    var listaFiltrada = string.IsNullOrWhiteSpace(filtro)
                        ? productos.ToList()
                        : productos.Where(p =>
                            (!string.IsNullOrEmpty(p.Nombre) && p.Nombre.Contains(filtro, StringComparison.OrdinalIgnoreCase)) ||
                            (!string.IsNullOrEmpty(p.Categoria) && p.Categoria.Contains(filtro, StringComparison.OrdinalIgnoreCase))
                          ).ToList();

                    var listaMostrar = listaFiltrada.Select(p => new
                    {
                        ID = p.Id_Productos,
                        Nombre = p.Nombre,
                        Precio = p.Precio,
                        Stock = p.Stock,
                        Categoría = p.Categoria,
                        Marca_ID = p.Id_Marca,
                        Proveedor_ID = p.Id_Proveedor
                    }).ToList();

                    dgvProductos.DataSource = null;
                    dgvProductos.DataSource = listaMostrar;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string texto = txtbBuscarProducto.Text.Trim();
            if (texto == "Buscar Producto...") texto = "";
            await CargarProductosAsync(texto);
        }

        private async void txtbBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            string texto = txtbBuscarProducto.Text.Trim();
            if (texto == "Buscar Producto...") return;
            await CargarProductosAsync(texto);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona una fila completa para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ID"].Value);
            string nombreProducto = dgvProductos.CurrentRow.Cells["Nombre"].Value.ToString();

            var confirmacion = MessageBox.Show($"¿Estás seguro de eliminar el producto '{nombreProducto}' (ID: {idProducto})?",
                                               "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    await _logicaProducto.EliminarAsync(idProducto);
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CargarProductosAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
