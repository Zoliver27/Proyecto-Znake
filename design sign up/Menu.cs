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
    }
}
