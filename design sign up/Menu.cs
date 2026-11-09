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
    public partial class Menu : Form
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

        public Menu()
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
        }
        public async Task CargarMetricasAsync() //---Para el boton de Inicio---
        {
            try
            {
                var ventas = await _logicaVenta.ObtenerTodosAsync();
                var clientes = await _logicaCliente.ObtenerTodosAsync();
                var productos = await _logicaProducto.ObtenerTodosAsync();

                decimal totalIngresos = ventas?.Sum(v => v.Total) ?? 0; // Asumiendo que la entidad Venta tiene la propiedad Total
                int totalClientes = clientes?.Count() ?? 0;
                int totalProductos = productos?.Count() ?? 0;
                int totalVentas = ventas?.Count() ?? 0;

                // 3. Asignar valores a los Labels
                lblTotalIngresos.Text = $"{totalIngresos:C2}"; // O $"{totalIngresos:N2} Bs"
                lblTotalClientes.Text = totalClientes.ToString("N0");
                lblTotalProductos.Text = totalProductos.ToString("N0");
                lblTotalVentas.Text = totalVentas.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las métricas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
