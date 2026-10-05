namespace design_sign_up
{
    partial class Gestion_Privada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            parrotGradientPanel2 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            dgv_GestionDueno = new DataGridView();
            dgv_GestionAdministrador = new DataGridView();
            lbl_GesDueno = new Label();
            lbl_GesAdministrador = new Label();
            form_GestionPriv = new ReaLTaiizor.Forms.HopeForm();
            cmb_PuestosT = new ComboBox();
            hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBox2 = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBox3 = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBox4 = new ReaLTaiizor.Controls.HopeTextBox();
            btn_RegistrarGPriv = new ReaLTaiizor.Controls.HopeButton();
            btn_LimpiarGPriv = new ReaLTaiizor.Controls.HopeButton();
            ((System.ComponentModel.ISupportInitialize)dgv_GestionDueno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_GestionAdministrador).BeginInit();
            SuspendLayout();
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
            parrotGradientPanel2.Size = new Size(1243, 54);
            parrotGradientPanel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel2.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Horizontal;
            parrotGradientPanel2.TabIndex = 15;
            parrotGradientPanel2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel2.TopLeft = Color.FromArgb(17, 17, 22);
            parrotGradientPanel2.TopRight = Color.FromArgb(27, 26, 32);
            // 
            // dgv_GestionDueno
            // 
            dgv_GestionDueno.BackgroundColor = Color.FromArgb(40, 40, 47);
            dgv_GestionDueno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_GestionDueno.Location = new Point(34, 79);
            dgv_GestionDueno.Name = "dgv_GestionDueno";
            dgv_GestionDueno.RowHeadersWidth = 51;
            dgv_GestionDueno.Size = new Size(679, 188);
            dgv_GestionDueno.TabIndex = 16;
            // 
            // dgv_GestionAdministrador
            // 
            dgv_GestionAdministrador.BackgroundColor = Color.FromArgb(40, 40, 47);
            dgv_GestionAdministrador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_GestionAdministrador.Location = new Point(34, 306);
            dgv_GestionAdministrador.Name = "dgv_GestionAdministrador";
            dgv_GestionAdministrador.RowHeadersWidth = 51;
            dgv_GestionAdministrador.Size = new Size(679, 188);
            dgv_GestionAdministrador.TabIndex = 17;
            // 
            // lbl_GesDueno
            // 
            lbl_GesDueno.AutoSize = true;
            lbl_GesDueno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_GesDueno.ForeColor = Color.White;
            lbl_GesDueno.Location = new Point(34, 48);
            lbl_GesDueno.Name = "lbl_GesDueno";
            lbl_GesDueno.Size = new Size(146, 28);
            lbl_GesDueno.TabIndex = 18;
            lbl_GesDueno.Text = "Gestion Dueno:";
            // 
            // lbl_GesAdministrador
            // 
            lbl_GesAdministrador.AutoSize = true;
            lbl_GesAdministrador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_GesAdministrador.ForeColor = Color.White;
            lbl_GesAdministrador.Location = new Point(34, 275);
            lbl_GesAdministrador.Name = "lbl_GesAdministrador";
            lbl_GesAdministrador.Size = new Size(214, 28);
            lbl_GesAdministrador.TabIndex = 19;
            lbl_GesAdministrador.Text = "Gestion Administrador:";
            // 
            // form_GestionPriv
            // 
            form_GestionPriv.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            form_GestionPriv.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            form_GestionPriv.ControlBoxColorN = Color.White;
            form_GestionPriv.Dock = DockStyle.Top;
            form_GestionPriv.Font = new Font("Segoe UI", 12F);
            form_GestionPriv.ForeColor = Color.FromArgb(242, 246, 252);
            form_GestionPriv.Image = null;
            form_GestionPriv.Location = new Point(0, 0);
            form_GestionPriv.Name = "form_GestionPriv";
            form_GestionPriv.Size = new Size(1244, 40);
            form_GestionPriv.TabIndex = 20;
            form_GestionPriv.ThemeColor = Color.FromArgb(17, 17, 22);
            // 
            // cmb_PuestosT
            // 
            cmb_PuestosT.BackColor = Color.FromArgb(40, 40, 47);
            cmb_PuestosT.ForeColor = Color.White;
            cmb_PuestosT.FormattingEnabled = true;
            cmb_PuestosT.Items.AddRange(new object[] { "Dueno", "Administrador" });
            cmb_PuestosT.Location = new Point(777, 436);
            cmb_PuestosT.Name = "cmb_PuestosT";
            cmb_PuestosT.Size = new Size(151, 28);
            cmb_PuestosT.TabIndex = 21;
            // 
            // hopeTextBox1
            // 
            hopeTextBox1.BackColor = Color.FromArgb(40, 40, 47);
            hopeTextBox1.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox1.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox1.BorderColorB = Color.Gray;
            hopeTextBox1.Font = new Font("Segoe UI", 12F);
            hopeTextBox1.ForeColor = Color.White;
            hopeTextBox1.Hint = "";
            hopeTextBox1.Location = new Point(777, 91);
            hopeTextBox1.MaxLength = 32767;
            hopeTextBox1.Multiline = false;
            hopeTextBox1.Name = "hopeTextBox1";
            hopeTextBox1.PasswordChar = '\0';
            hopeTextBox1.ScrollBars = ScrollBars.None;
            hopeTextBox1.SelectedText = "";
            hopeTextBox1.SelectionLength = 0;
            hopeTextBox1.SelectionStart = 0;
            hopeTextBox1.Size = new Size(401, 43);
            hopeTextBox1.TabIndex = 22;
            hopeTextBox1.TabStop = false;
            hopeTextBox1.Text = "Nombre";
            hopeTextBox1.UseSystemPasswordChar = false;
            // 
            // hopeTextBox2
            // 
            hopeTextBox2.BackColor = Color.FromArgb(40, 40, 47);
            hopeTextBox2.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox2.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox2.BorderColorB = Color.Gray;
            hopeTextBox2.Font = new Font("Segoe UI", 12F);
            hopeTextBox2.ForeColor = Color.White;
            hopeTextBox2.Hint = "";
            hopeTextBox2.Location = new Point(777, 173);
            hopeTextBox2.MaxLength = 32767;
            hopeTextBox2.Multiline = false;
            hopeTextBox2.Name = "hopeTextBox2";
            hopeTextBox2.PasswordChar = '\0';
            hopeTextBox2.ScrollBars = ScrollBars.None;
            hopeTextBox2.SelectedText = "";
            hopeTextBox2.SelectionLength = 0;
            hopeTextBox2.SelectionStart = 0;
            hopeTextBox2.Size = new Size(401, 43);
            hopeTextBox2.TabIndex = 23;
            hopeTextBox2.TabStop = false;
            hopeTextBox2.Text = "Email";
            hopeTextBox2.UseSystemPasswordChar = false;
            // 
            // hopeTextBox3
            // 
            hopeTextBox3.BackColor = Color.FromArgb(40, 40, 47);
            hopeTextBox3.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox3.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox3.BorderColorB = Color.Gray;
            hopeTextBox3.Font = new Font("Segoe UI", 12F);
            hopeTextBox3.ForeColor = Color.White;
            hopeTextBox3.Hint = "";
            hopeTextBox3.Location = new Point(777, 255);
            hopeTextBox3.MaxLength = 32767;
            hopeTextBox3.Multiline = false;
            hopeTextBox3.Name = "hopeTextBox3";
            hopeTextBox3.PasswordChar = '\0';
            hopeTextBox3.ScrollBars = ScrollBars.None;
            hopeTextBox3.SelectedText = "";
            hopeTextBox3.SelectionLength = 0;
            hopeTextBox3.SelectionStart = 0;
            hopeTextBox3.Size = new Size(401, 43);
            hopeTextBox3.TabIndex = 24;
            hopeTextBox3.TabStop = false;
            hopeTextBox3.Text = "Edad";
            hopeTextBox3.UseSystemPasswordChar = false;
            // 
            // hopeTextBox4
            // 
            hopeTextBox4.BackColor = Color.FromArgb(40, 40, 47);
            hopeTextBox4.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox4.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox4.BorderColorB = Color.Gray;
            hopeTextBox4.Font = new Font("Segoe UI", 12F);
            hopeTextBox4.ForeColor = Color.White;
            hopeTextBox4.Hint = "";
            hopeTextBox4.Location = new Point(777, 333);
            hopeTextBox4.MaxLength = 32767;
            hopeTextBox4.Multiline = false;
            hopeTextBox4.Name = "hopeTextBox4";
            hopeTextBox4.PasswordChar = '\0';
            hopeTextBox4.ScrollBars = ScrollBars.None;
            hopeTextBox4.SelectedText = "";
            hopeTextBox4.SelectionLength = 0;
            hopeTextBox4.SelectionStart = 0;
            hopeTextBox4.Size = new Size(401, 43);
            hopeTextBox4.TabIndex = 25;
            hopeTextBox4.TabStop = false;
            hopeTextBox4.Text = "Telefono";
            hopeTextBox4.UseSystemPasswordChar = false;
            // 
            // btn_RegistrarGPriv
            // 
            btn_RegistrarGPriv.BorderColor = Color.FromArgb(20, 20, 25);
            btn_RegistrarGPriv.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_RegistrarGPriv.DangerColor = Color.FromArgb(170, 55, 55);
            btn_RegistrarGPriv.DefaultColor = Color.FromArgb(34, 35, 43);
            btn_RegistrarGPriv.Font = new Font("Segoe UI", 12F);
            btn_RegistrarGPriv.HoverTextColor = Color.White;
            btn_RegistrarGPriv.InfoColor = Color.FromArgb(55, 125, 200);
            btn_RegistrarGPriv.Location = new Point(1004, 405);
            btn_RegistrarGPriv.Name = "btn_RegistrarGPriv";
            btn_RegistrarGPriv.PrimaryColor = Color.FromArgb(34, 35, 43);
            btn_RegistrarGPriv.Size = new Size(150, 40);
            btn_RegistrarGPriv.SuccessColor = Color.FromArgb(55, 150, 100);
            btn_RegistrarGPriv.TabIndex = 26;
            btn_RegistrarGPriv.Text = "Registrar";
            btn_RegistrarGPriv.TextColor = Color.FromArgb(235, 235, 240);
            btn_RegistrarGPriv.WarningColor = Color.FromArgb(200, 145, 50);
            btn_RegistrarGPriv.Click += btn_RegistrarGPriv_Click;
            // 
            // btn_LimpiarGPriv
            // 
            btn_LimpiarGPriv.BorderColor = Color.FromArgb(20, 20, 25);
            btn_LimpiarGPriv.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_LimpiarGPriv.DangerColor = Color.FromArgb(170, 55, 55);
            btn_LimpiarGPriv.DefaultColor = Color.FromArgb(34, 35, 43);
            btn_LimpiarGPriv.Font = new Font("Segoe UI", 12F);
            btn_LimpiarGPriv.HoverTextColor = Color.White;
            btn_LimpiarGPriv.InfoColor = Color.FromArgb(55, 125, 200);
            btn_LimpiarGPriv.Location = new Point(1004, 469);
            btn_LimpiarGPriv.Name = "btn_LimpiarGPriv";
            btn_LimpiarGPriv.PrimaryColor = Color.FromArgb(34, 35, 43);
            btn_LimpiarGPriv.Size = new Size(150, 40);
            btn_LimpiarGPriv.SuccessColor = Color.FromArgb(55, 150, 100);
            btn_LimpiarGPriv.TabIndex = 27;
            btn_LimpiarGPriv.Text = "Limpiar";
            btn_LimpiarGPriv.TextColor = Color.FromArgb(235, 235, 240);
            btn_LimpiarGPriv.WarningColor = Color.FromArgb(200, 145, 50);
            // 
            // Gestion_Privada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 22);
            ClientSize = new Size(1244, 550);
            Controls.Add(btn_LimpiarGPriv);
            Controls.Add(btn_RegistrarGPriv);
            Controls.Add(hopeTextBox4);
            Controls.Add(hopeTextBox3);
            Controls.Add(hopeTextBox2);
            Controls.Add(hopeTextBox1);
            Controls.Add(cmb_PuestosT);
            Controls.Add(form_GestionPriv);
            Controls.Add(lbl_GesAdministrador);
            Controls.Add(lbl_GesDueno);
            Controls.Add(dgv_GestionAdministrador);
            Controls.Add(dgv_GestionDueno);
            Controls.Add(parrotGradientPanel2);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1020);
            MinimumSize = new Size(190, 40);
            Name = "Gestion_Privada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion_Privada";
            ((System.ComponentModel.ISupportInitialize)dgv_GestionDueno).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_GestionAdministrador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel2;
        private DataGridView dgv_GestionDueno;
        private DataGridView dgv_GestionAdministrador;
        private Label lbl_GesDueno;
        private Label lbl_GesAdministrador;
        private ReaLTaiizor.Forms.HopeForm form_GestionPriv;
        private ComboBox cmb_PuestosT;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox2;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox3;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox4;
        private ReaLTaiizor.Controls.HopeButton btn_RegistrarGPriv;
        private ReaLTaiizor.Controls.HopeButton btn_LimpiarGPriv;
    }
}