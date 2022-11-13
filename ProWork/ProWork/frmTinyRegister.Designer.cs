namespace ProWork
{
    partial class frmTinyRegister
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
            this.components = new System.ComponentModel.Container();
            this.utbNombre = new ProWork.UnderlinedTextBox();
            this.cbtCrear = new ProWork.CustomButton();
            this.lblLogin = new System.Windows.Forms.Label();
            this.bgwCheck = new System.ComponentModel.BackgroundWorker();
            this.tmrIntoRegister = new System.Windows.Forms.Timer(this.components);
            this.tmrIntoLogin = new System.Windows.Forms.Timer(this.components);
            this.utbContra = new ProWork.PasswordUnderlinedTextBox();
            this.utbCContra = new ProWork.PasswordUnderlinedTextBox();
            this.pbxUser = new ProWork.enhancedPictureBox();
            this.pbPlusUser = new ProWork.enhancedPictureBox();
            this.SuspendLayout();
            // 
            // utbNombre
            // 
            this.utbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.utbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbNombre.Location = new System.Drawing.Point(119, 349);
            this.utbNombre.Name = "utbNombre";
            this.utbNombre.PlaceholderText = "Nombre";
            this.utbNombre.Size = new System.Drawing.Size(344, 36);
            this.utbNombre.TabIndex = 2;
            this.utbNombre.txbText = "";
            this.utbNombre.UsePasswordChar = false;
            this.utbNombre.EnterPressed += new System.EventHandler(this.cbtCrear_Click);
            // 
            // cbtCrear
            // 
            this.cbtCrear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbtCrear.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtCrear.Location = new System.Drawing.Point(108, 569);
            this.cbtCrear.Name = "cbtCrear";
            this.cbtCrear.Size = new System.Drawing.Size(366, 68);
            this.cbtCrear.TabIndex = 5;
            this.cbtCrear.Texto = "CREAR";
            this.cbtCrear.ButtonClick += new System.EventHandler(this.cbtCrear_Click);
            this.cbtCrear.Click += new System.EventHandler(this.cbtCrear_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLogin.Location = new System.Drawing.Point(119, 499);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(344, 25);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "¿Ya tienes una cuenta? Inicia sesión";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            this.lblLogin.MouseEnter += new System.EventHandler(this.lblLogin_MouseEnter);
            this.lblLogin.MouseLeave += new System.EventHandler(this.lblLogin_MouseLeave);
            // 
            // bgwCheck
            // 
            this.bgwCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCheck_DoWork);
            this.bgwCheck.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCheck_RunWorkerCompleted);
            // 
            // tmrIntoRegister
            // 
            this.tmrIntoRegister.Interval = 16;
            this.tmrIntoRegister.Tick += new System.EventHandler(this.tmrIntoRegister_Tick);
            // 
            // tmrIntoLogin
            // 
            this.tmrIntoLogin.Interval = 16;
            this.tmrIntoLogin.Tick += new System.EventHandler(this.tmrIntoLogin_Tick);
            // 
            // utbContra
            // 
            this.utbContra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.utbContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbContra.Location = new System.Drawing.Point(119, 400);
            this.utbContra.Name = "utbContra";
            this.utbContra.PlaceholderText = "Contraseña";
            this.utbContra.Size = new System.Drawing.Size(344, 36);
            this.utbContra.TabIndex = 16;
            this.utbContra.txbText = "";
            this.utbContra.UsePasswordChar = true;
            this.utbContra.EnterPressed += new System.EventHandler(this.cbtCrear_Click);
            // 
            // utbCContra
            // 
            this.utbCContra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.utbCContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbCContra.Location = new System.Drawing.Point(119, 451);
            this.utbCContra.Name = "utbCContra";
            this.utbCContra.PlaceholderText = "Confirmar Contraseña";
            this.utbCContra.Size = new System.Drawing.Size(344, 36);
            this.utbCContra.TabIndex = 17;
            this.utbCContra.txbText = "";
            this.utbCContra.UsePasswordChar = true;
            this.utbCContra.EnterPressed += new System.EventHandler(this.cbtCrear_Click);
            // 
            // pbxUser
            // 
            this.pbxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxUser.BackColor = System.Drawing.Color.Transparent;
            this.pbxUser.BkgImage = global::ProWork.Properties.Resources.Usuario_azul;
            this.pbxUser.Circle = false;
            this.pbxUser.Location = new System.Drawing.Point(217, 117);
            this.pbxUser.Margin = new System.Windows.Forms.Padding(6);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(153, 211);
            this.pbxUser.TabIndex = 18;
            // 
            // pbPlusUser
            // 
            this.pbPlusUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPlusUser.BackColor = System.Drawing.Color.Transparent;
            this.pbPlusUser.BkgImage = global::ProWork.Properties.Resources.MasUsuario_Azul;
            this.pbPlusUser.Circle = false;
            this.pbPlusUser.Location = new System.Drawing.Point(357, 191);
            this.pbPlusUser.Margin = new System.Windows.Forms.Padding(6);
            this.pbPlusUser.Name = "pbPlusUser";
            this.pbPlusUser.Size = new System.Drawing.Size(62, 62);
            this.pbPlusUser.TabIndex = 19;
            // 
            // frmTinyRegister
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(582, 753);
            this.Controls.Add(this.pbPlusUser);
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.cbtCrear);
            this.Controls.Add(this.utbNombre);
            this.Controls.Add(this.utbContra);
            this.Controls.Add(this.utbCContra);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(417, 616);
            this.Name = "frmTinyRegister";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrarme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTinyRegister_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private UnderlinedTextBox utbNombre;
        private CustomButton cbtCrear;
        private Label lblLogin;
        private System.ComponentModel.BackgroundWorker bgwCheck;
        private System.Windows.Forms.Timer tmrIntoRegister;
        private System.Windows.Forms.Timer tmrIntoLogin;
        private PasswordUnderlinedTextBox utbContra;
        private PasswordUnderlinedTextBox utbCContra;
        private enhancedPictureBox pbxUser;
        private enhancedPictureBox pbPlusUser;
    }
}