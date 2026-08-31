namespace design_sign_up
{
    partial class Sign_Up
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lbl_HaveAccount = new Label();
            btn_SignUp = new ReaLTaiizor.Controls.HopeButton();
            lbl_Password = new Label();
            txb_Password = new ReaLTaiizor.Controls.HopeTextBox();
            lbl_Email = new Label();
            txb_Email = new ReaLTaiizor.Controls.HopeTextBox();
            lbl_UserName = new Label();
            txb_UserName = new ReaLTaiizor.Controls.HopeTextBox();
            label1 = new Label();
            frm_HighBar = new ReaLTaiizor.Forms.HopeForm();
            pictureBox1 = new PictureBox();
            lbl_SignUp = new Label();
            lbl_Slogan = new Label();
            lbl_Znake = new Label();
            parrotGradientPanel2 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 40, 45);
            panel1.Controls.Add(lbl_HaveAccount);
            panel1.Controls.Add(btn_SignUp);
            panel1.Controls.Add(lbl_Password);
            panel1.Controls.Add(txb_Password);
            panel1.Controls.Add(lbl_Email);
            panel1.Controls.Add(txb_Email);
            panel1.Controls.Add(lbl_UserName);
            panel1.Controls.Add(txb_UserName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(80, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 450);
            panel1.TabIndex = 0;
            // 
            // lbl_HaveAccount
            // 
            lbl_HaveAccount.AutoSize = true;
            lbl_HaveAccount.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_HaveAccount.ForeColor = Color.FromArgb(184, 181, 190);
            lbl_HaveAccount.Location = new Point(110, 425);
            lbl_HaveAccount.Name = "lbl_HaveAccount";
            lbl_HaveAccount.Size = new Size(115, 16);
            lbl_HaveAccount.TabIndex = 11;
            lbl_HaveAccount.Text = "Have an account?";
            lbl_HaveAccount.TextAlign = ContentAlignment.MiddleCenter;
            lbl_HaveAccount.Click += lbl_HaveAccount_Click;
            // 
            // btn_SignUp
            // 
            btn_SignUp.BorderColor = Color.FromArgb(220, 223, 230);
            btn_SignUp.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_SignUp.DangerColor = Color.FromArgb(245, 108, 108);
            btn_SignUp.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_SignUp.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_SignUp.ForeColor = Color.White;
            btn_SignUp.HoverTextColor = Color.White;
            btn_SignUp.InfoColor = Color.FromArgb(144, 147, 153);
            btn_SignUp.Location = new Point(93, 365);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.PrimaryColor = Color.FromArgb(61, 58, 66);
            btn_SignUp.Size = new Size(150, 40);
            btn_SignUp.SuccessColor = Color.White;
            btn_SignUp.TabIndex = 9;
            btn_SignUp.Text = "Sign Up";
            btn_SignUp.TextColor = Color.White;
            btn_SignUp.WarningColor = Color.FromArgb(61, 58, 66);
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Password.ForeColor = Color.White;
            lbl_Password.Location = new Point(17, 268);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(88, 20);
            lbl_Password.TabIndex = 8;
            lbl_Password.Text = "Password:";
            lbl_Password.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txb_Password
            // 
            txb_Password.BackColor = Color.FromArgb(36, 35, 40);
            txb_Password.BaseColor = Color.FromArgb(41, 40, 45);
            txb_Password.BorderColorA = Color.FromArgb(74, 71, 80);
            txb_Password.BorderColorB = Color.FromArgb(34, 33, 38);
            txb_Password.Font = new Font("Segoe UI", 12F);
            txb_Password.ForeColor = Color.White;
            txb_Password.Hint = "";
            txb_Password.Location = new Point(17, 291);
            txb_Password.MaxLength = 32767;
            txb_Password.Multiline = false;
            txb_Password.Name = "txb_Password";
            txb_Password.PasswordChar = '\0';
            txb_Password.ScrollBars = ScrollBars.None;
            txb_Password.SelectedText = "";
            txb_Password.SelectionLength = 0;
            txb_Password.SelectionStart = 0;
            txb_Password.Size = new Size(309, 43);
            txb_Password.TabIndex = 7;
            txb_Password.TabStop = false;
            txb_Password.UseSystemPasswordChar = false;
            txb_Password.Click += txb_Password_Click;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Email.ForeColor = Color.White;
            lbl_Email.Location = new Point(17, 171);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(56, 20);
            lbl_Email.TabIndex = 6;
            lbl_Email.Text = "Email:";
            lbl_Email.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txb_Email
            // 
            txb_Email.BackColor = Color.FromArgb(36, 35, 40);
            txb_Email.BaseColor = Color.FromArgb(41, 40, 45);
            txb_Email.BorderColorA = Color.FromArgb(74, 71, 80);
            txb_Email.BorderColorB = Color.FromArgb(34, 33, 38);
            txb_Email.Font = new Font("Segoe UI", 12F);
            txb_Email.ForeColor = Color.White;
            txb_Email.Hint = "";
            txb_Email.Location = new Point(17, 194);
            txb_Email.MaxLength = 32767;
            txb_Email.Multiline = false;
            txb_Email.Name = "txb_Email";
            txb_Email.PasswordChar = '\0';
            txb_Email.ScrollBars = ScrollBars.None;
            txb_Email.SelectedText = "";
            txb_Email.SelectionLength = 0;
            txb_Email.SelectionStart = 0;
            txb_Email.Size = new Size(309, 43);
            txb_Email.TabIndex = 5;
            txb_Email.TabStop = false;
            txb_Email.UseSystemPasswordChar = false;
            // 
            // lbl_UserName
            // 
            lbl_UserName.AutoSize = true;
            lbl_UserName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_UserName.ForeColor = Color.White;
            lbl_UserName.Location = new Point(17, 75);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(99, 20);
            lbl_UserName.TabIndex = 2;
            lbl_UserName.Text = "User Name:";
            lbl_UserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txb_UserName
            // 
            txb_UserName.BackColor = Color.FromArgb(36, 35, 40);
            txb_UserName.BaseColor = Color.FromArgb(41, 40, 45);
            txb_UserName.BorderColorA = Color.FromArgb(74, 71, 80);
            txb_UserName.BorderColorB = Color.FromArgb(34, 33, 38);
            txb_UserName.Font = new Font("Segoe UI", 12F);
            txb_UserName.ForeColor = Color.White;
            txb_UserName.Hint = "";
            txb_UserName.Location = new Point(17, 98);
            txb_UserName.MaxLength = 32767;
            txb_UserName.Multiline = false;
            txb_UserName.Name = "txb_UserName";
            txb_UserName.PasswordChar = '\0';
            txb_UserName.ScrollBars = ScrollBars.None;
            txb_UserName.SelectedText = "";
            txb_UserName.SelectionLength = 0;
            txb_UserName.SelectionStart = 0;
            txb_UserName.Size = new Size(309, 43);
            txb_UserName.TabIndex = 1;
            txb_UserName.TabStop = false;
            txb_UserName.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(110, 25);
            label1.Name = "label1";
            label1.Size = new Size(115, 32);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frm_HighBar
            // 
            frm_HighBar.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            frm_HighBar.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            frm_HighBar.ControlBoxColorN = Color.White;
            frm_HighBar.Dock = DockStyle.Top;
            frm_HighBar.Font = new Font("Segoe UI", 12F);
            frm_HighBar.ForeColor = Color.FromArgb(242, 246, 252);
            frm_HighBar.Image = null;
            frm_HighBar.Location = new Point(0, 0);
            frm_HighBar.Name = "frm_HighBar";
            frm_HighBar.Size = new Size(950, 40);
            frm_HighBar.TabIndex = 1;
            frm_HighBar.ThemeColor = Color.FromArgb(17, 17, 22);
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.SnakeLogo1;
            pictureBox1.Location = new Point(590, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lbl_SignUp
            // 
            lbl_SignUp.AutoSize = true;
            lbl_SignUp.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_SignUp.ForeColor = Color.White;
            lbl_SignUp.Location = new Point(655, 475);
            lbl_SignUp.Name = "lbl_SignUp";
            lbl_SignUp.Size = new Size(138, 20);
            lbl_SignUp.TabIndex = 10;
            lbl_SignUp.Text = "Sign up to join us";
            lbl_SignUp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Slogan
            // 
            lbl_Slogan.AutoSize = true;
            lbl_Slogan.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Slogan.ForeColor = Color.White;
            lbl_Slogan.Location = new Point(640, 390);
            lbl_Slogan.Name = "lbl_Slogan";
            lbl_Slogan.Size = new Size(157, 22);
            lbl_Slogan.TabIndex = 11;
            lbl_Slogan.Text = "Level up your tech";
            lbl_Slogan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Znake
            // 
            lbl_Znake.AutoSize = true;
            lbl_Znake.BackColor = Color.Transparent;
            lbl_Znake.Font = new Font("Lucida Sans", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Znake.ForeColor = Color.White;
            lbl_Znake.Location = new Point(655, 345);
            lbl_Znake.Name = "lbl_Znake";
            lbl_Znake.Size = new Size(124, 39);
            lbl_Znake.TabIndex = 12;
            lbl_Znake.Text = "Znake";
            lbl_Znake.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // parrotGradientPanel2
            // 
            parrotGradientPanel2.BottomLeft = Color.FromArgb(17, 17, 22);
            parrotGradientPanel2.BottomRight = Color.FromArgb(27, 26, 32);
            parrotGradientPanel2.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel2.Location = new Point(0, 500);
            parrotGradientPanel2.Name = "parrotGradientPanel2";
            parrotGradientPanel2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel2.PrimerColor = Color.White;
            parrotGradientPanel2.Size = new Size(950, 54);
            parrotGradientPanel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel2.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Horizontal;
            parrotGradientPanel2.TabIndex = 14;
            parrotGradientPanel2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel2.TopLeft = Color.FromArgb(17, 17, 22);
            parrotGradientPanel2.TopRight = Color.FromArgb(27, 26, 32);
            // 
            // Sign_Up
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 22);
            ClientSize = new Size(950, 550);
            Controls.Add(parrotGradientPanel2);
            Controls.Add(lbl_SignUp);
            Controls.Add(lbl_Znake);
            Controls.Add(lbl_Slogan);
            Controls.Add(pictureBox1);
            Controls.Add(frm_HighBar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1020);
            MinimumSize = new Size(190, 40);
            Name = "Sign_Up";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ReaLTaiizor.Controls.HopeTextBox txb_UserName;
        private ReaLTaiizor.Forms.HopeForm frm_HighBar;
        private Label lbl_Password;
        private ReaLTaiizor.Controls.HopeTextBox txb_Password;
        private Label lbl_Email;
        private ReaLTaiizor.Controls.HopeTextBox txb_Email;
        private Label lbl_UserName;
        private ReaLTaiizor.Controls.HopeButton btn_SignUp;
        private PictureBox pictureBox1;
        private Label lbl_SignUp;
        private Label lbl_Slogan;
        private Label lbl_Znake;
        private Label lbl_HaveAccount;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel2;
    }
}
