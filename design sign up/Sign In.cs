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
    public partial class Sign_In : Form
    {
        public Sign_In()
        {
            InitializeComponent();
            this.MaximizeBox = false;

        }

        private void lbl_NoAccount_Click(object sender, EventArgs e)
        {
            Sign_Up SU = new Sign_Up();
            SU.Show();
            this.Close();
        }

        private void Sign_In_Load(object sender, EventArgs e)
        {

        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            if (txb_Email.Text == "ola" && txb_Password.Text == "1234")
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
        }
    }
}
