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
            txb_Nombre = new ReaLTaiizor.Controls.HopeTextBox();
            txb_Email = new ReaLTaiizor.Controls.HopeTextBox();
            txb_Edad = new ReaLTaiizor.Controls.HopeTextBox();
            txb_Telefono = new ReaLTaiizor.Controls.HopeTextBox();
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
            // txb_Nombre
            // 
            txb_Nombre.BackColor = Color.FromArgb(40, 40, 47);
            txb_Nombre.BaseColor = Color.FromArgb(44, 55, 66);
            txb_Nombre.BorderColorA = Color.FromArgb(64, 158, 255);
            txb_Nombre.BorderColorB = Color.Gray;
            txb_Nombre.Font = new Font("Segoe UI", 12F);
            txb_Nombre.ForeColor = Color.White;
            txb_Nombre.Hint = "";
            txb_Nombre.Location = new Point(777, 91);
            txb_Nombre.MaxLength = 32767;
            txb_Nombre.Multiline = false;
            txb_Nombre.Name = "txb_Nombre";
            txb_Nombre.PasswordChar = '\0';
            txb_Nombre.ScrollBars = ScrollBars.None;
            txb_Nombre.SelectedText = "";
            txb_Nombre.SelectionLength = 0;
            txb_Nombre.SelectionStart = 0;
            txb_Nombre.Size = new Size(401, 43);
            txb_Nombre.TabIndex = 22;
            txb_Nombre.TabStop = false;
            txb_Nombre.Text = "Nombre";
            txb_Nombre.UseSystemPasswordChar = false;
            // 
            // txb_Email
            // 
            txb_Email.BackColor = Color.FromArgb(40, 40, 47);
            txb_Email.BaseColor = Color.FromArgb(44, 55, 66);
            txb_Email.BorderColorA = Color.FromArgb(64, 158, 255);
            txb_Email.BorderColorB = Color.Gray;
            txb_Email.Font = new Font("Segoe UI", 12F);
            txb_Email.ForeColor = Color.White;
            txb_Email.Hint = "";
            txb_Email.Location = new Point(777, 173);
            txb_Email.MaxLength = 32767;
            txb_Email.Multiline = false;
            txb_Email.Name = "txb_Email";
            txb_Email.PasswordChar = '\0';
            txb_Email.ScrollBars = ScrollBars.None;
            txb_Email.SelectedText = "";
            txb_Email.SelectionLength = 0;
            txb_Email.SelectionStart = 0;
            txb_Email.Size = new Size(401, 43);
            txb_Email.TabIndex = 23;
            txb_Email.TabStop = false;
            txb_Email.Text = "Email";
            txb_Email.UseSystemPasswordChar = false;
            // 
            // txb_Edad
            // 
            txb_Edad.BackColor = Color.FromArgb(40, 40, 47);
            txb_Edad.BaseColor = Color.FromArgb(44, 55, 66);
            txb_Edad.BorderColorA = Color.FromArgb(64, 158, 255);
            txb_Edad.BorderColorB = Color.Gray;
            txb_Edad.Font = new Font("Segoe UI", 12F);
            txb_Edad.ForeColor = Color.White;
            txb_Edad.Hint = "";
            txb_Edad.Location = new Point(777, 255);
            txb_Edad.MaxLength = 32767;
            txb_Edad.Multiline = false;
            txb_Edad.Name = "txb_Edad";
            txb_Edad.PasswordChar = '\0';
            txb_Edad.ScrollBars = ScrollBars.None;
            txb_Edad.SelectedText = "";
            txb_Edad.SelectionLength = 0;
            txb_Edad.SelectionStart = 0;
            txb_Edad.Size = new Size(401, 43);
            txb_Edad.TabIndex = 24;
            txb_Edad.TabStop = false;
            txb_Edad.Text = "Edad";
            txb_Edad.UseSystemPasswordChar = false;
            // 
            // txb_Telefono
            // 
            txb_Telefono.BackColor = Color.FromArgb(40, 40, 47);
            txb_Telefono.BaseColor = Color.FromArgb(44, 55, 66);
            txb_Telefono.BorderColorA = Color.FromArgb(64, 158, 255);
            txb_Telefono.BorderColorB = Color.Gray;
            txb_Telefono.Font = new Font("Segoe UI", 12F);
            txb_Telefono.ForeColor = Color.White;
            txb_Telefono.Hint = "";
            txb_Telefono.Location = new Point(777, 333);
            txb_Telefono.MaxLength = 32767;
            txb_Telefono.Multiline = false;
            txb_Telefono.Name = "txb_Telefono";
            txb_Telefono.PasswordChar = '\0';
            txb_Telefono.ScrollBars = ScrollBars.None;
            txb_Telefono.SelectedText = "";
            txb_Telefono.SelectionLength = 0;
            txb_Telefono.SelectionStart = 0;
            txb_Telefono.Size = new Size(401, 43);
            txb_Telefono.TabIndex = 25;
            txb_Telefono.TabStop = false;
            txb_Telefono.Text = "Telefono";
            txb_Telefono.UseSystemPasswordChar = false;
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
            Controls.Add(txb_Telefono);
            Controls.Add(txb_Edad);
            Controls.Add(txb_Email);
            Controls.Add(txb_Nombre);
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
            Load += Gestion_Privada_Load;
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
        private ReaLTaiizor.Controls.HopeTextBox txb_Nombre;
        private ReaLTaiizor.Controls.HopeTextBox txb_Email;
        private ReaLTaiizor.Controls.HopeTextBox txb_Edad;
        private ReaLTaiizor.Controls.HopeTextBox txb_Telefono;
        private ReaLTaiizor.Controls.HopeButton btn_RegistrarGPriv;
        private ReaLTaiizor.Controls.HopeButton btn_LimpiarGPriv;
    }
}