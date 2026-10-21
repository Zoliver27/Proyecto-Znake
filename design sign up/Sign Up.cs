using Logica_Znake;

namespace design_sign_up
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
            this.MaximizeBox = false;

        }

        private void txb_Password_Click(object sender, EventArgs e)
        {

        }

        private void lbl_HaveAccount_Click(object sender, EventArgs e)
        {
            Sign_In SI = new Sign_In();
            SI.Show();
            this.Hide();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            Gestion_Privada gp = new Gestion_Privada();
            gp.Show();
            this.Hide();
        }
    }
}
