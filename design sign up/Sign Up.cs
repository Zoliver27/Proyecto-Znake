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
    }
}
