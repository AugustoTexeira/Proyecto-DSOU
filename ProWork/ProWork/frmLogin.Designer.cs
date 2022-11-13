namespace ProWork
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.btnSwap = new System.Windows.Forms.Button();
            this.pnlForeground = new System.Windows.Forms.Panel();
            this.pbxFondoLogo = new System.Windows.Forms.PictureBox();
            this.tmrIntoLogin = new System.Windows.Forms.Timer(this.components);
            this.tmrIntoRegister = new System.Windows.Forms.Timer(this.components);
            this.bgwCheck = new System.ComponentModel.BackgroundWorker();
            this.btnLogin = new ProWork.CustomButton();
            this.ctbNombre = new ProWork.UnderlinedTextBox();
            this.epbUser = new ProWork.enhancedPictureBox();
            this.epbPlusUser = new ProWork.enhancedPictureBox();
            this.ctbContra = new ProWork.PasswordUnderlinedTextBox();
            this.ctbCContra = new ProWork.PasswordUnderlinedTextBox();
            this.pnlForeground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondoLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSwap
            // 
            this.btnSwap.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSwap.BackColor = System.Drawing.Color.Transparent;
            this.btnSwap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwap.FlatAppearance.BorderSize = 0;
            this.btnSwap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSwap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(49)))), ((int)(((byte)(247)))));
            this.btnSwap.Location = new System.Drawing.Point(930, 511);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(297, 29);
            this.btnSwap.TabIndex = 1;
            this.btnSwap.Text = "¿Tienes una cuenta? Inicia sesión";
            this.btnSwap.UseVisualStyleBackColor = false;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            this.btnSwap.MouseEnter += new System.EventHandler(this.btnSwap_MouseEnter);
            this.btnSwap.MouseLeave += new System.EventHandler(this.btnSwap_MouseLeave);
            // 
            // pnlForeground
            // 
            this.pnlForeground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForeground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlForeground.Controls.Add(this.pbxFondoLogo);
            this.pnlForeground.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(15)))));
            this.pnlForeground.Location = new System.Drawing.Point(0, 0);
            this.pnlForeground.Name = "pnlForeground";
            this.pnlForeground.Size = new System.Drawing.Size(872, 674);
            this.pnlForeground.TabIndex = 8;
            this.pnlForeground.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlForeground_Paint);
            // 
            // pbxFondoLogo
            // 
            this.pbxFondoLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxFondoLogo.Image = global::ProWork.Properties.Resources.fondito_2;
            this.pbxFondoLogo.Location = new System.Drawing.Point(-364, -113);
            this.pbxFondoLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxFondoLogo.Name = "pbxFondoLogo";
            this.pbxFondoLogo.Size = new System.Drawing.Size(1600, 900);
            this.pbxFondoLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFondoLogo.TabIndex = 0;
            this.pbxFondoLogo.TabStop = false;
            // 
            // tmrIntoLogin
            // 
            this.tmrIntoLogin.Interval = 16;
            this.tmrIntoLogin.Tick += new System.EventHandler(this.tmrIntoLogin_Tick);
            // 
            // tmrIntoRegister
            // 
            this.tmrIntoRegister.Interval = 16;
            this.tmrIntoRegister.Tick += new System.EventHandler(this.tmrIntoRegister_Tick);
            // 
            // bgwCheck
            // 
            this.bgwCheck.WorkerReportsProgress = true;
            this.bgwCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkLogin);
            this.bgwCheck.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCheck_RunWorkerCompleted);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(930, 452);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(297, 51);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Texto = "Crear";
            this.btnLogin.ButtonClick += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ctbNombre
            // 
            this.ctbNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ctbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ctbNombre.Location = new System.Drawing.Point(922, 302);
            this.ctbNombre.Name = "ctbNombre";
            this.ctbNombre.PlaceholderText = "Nombre";
            this.ctbNombre.Size = new System.Drawing.Size(313, 36);
            this.ctbNombre.TabIndex = 19;
            this.ctbNombre.txbText = "";
            this.ctbNombre.UsePasswordChar = false;
            // 
            // epbUser
            // 
            this.epbUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.epbUser.BackColor = System.Drawing.Color.Transparent;
            this.epbUser.BkgImage = global::ProWork.Properties.Resources.Usuario_azul;
            this.epbUser.Circle = false;
            this.epbUser.Location = new System.Drawing.Point(1024, 134);
            this.epbUser.Name = "epbUser";
            this.epbUser.Size = new System.Drawing.Size(104, 141);
            this.epbUser.TabIndex = 20;
            // 
            // epbPlusUser
            // 
            this.epbPlusUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.epbPlusUser.BackColor = System.Drawing.Color.Transparent;
            this.epbPlusUser.BkgImage = global::ProWork.Properties.Resources.MasUsuario_Azul;
            this.epbPlusUser.Circle = false;
            this.epbPlusUser.Location = new System.Drawing.Point(1121, 180);
            this.epbPlusUser.Name = "epbPlusUser";
            this.epbPlusUser.Size = new System.Drawing.Size(37, 37);
            this.epbPlusUser.TabIndex = 21;
            // 
            // ctbContra
            // 
            this.ctbContra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ctbContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ctbContra.Location = new System.Drawing.Point(922, 345);
            this.ctbContra.Name = "ctbContra";
            this.ctbContra.PlaceholderText = "Contraseña";
            this.ctbContra.Size = new System.Drawing.Size(312, 36);
            this.ctbContra.TabIndex = 22;
            this.ctbContra.txbText = "";
            this.ctbContra.UsePasswordChar = true;
            // 
            // ctbCContra
            // 
            this.ctbCContra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ctbCContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ctbCContra.Location = new System.Drawing.Point(922, 387);
            this.ctbCContra.Name = "ctbCContra";
            this.ctbCContra.PlaceholderText = "Confirmar contraseña";
            this.ctbCContra.Size = new System.Drawing.Size(313, 36);
            this.ctbCContra.TabIndex = 23;
            this.ctbCContra.txbText = "";
            this.ctbCContra.UsePasswordChar = true;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1277, 674);
            this.Controls.Add(this.epbPlusUser);
            this.Controls.Add(this.ctbNombre);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.pnlForeground);
            this.Controls.Add(this.epbUser);
            this.Controls.Add(this.ctbContra);
            this.Controls.Add(this.ctbCContra);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(423, 535);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prowork";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.frmLogin_Layout);
            this.Resize += new System.EventHandler(this.frmLogin_Resize);
            this.pnlForeground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondoLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnSwap;
        private Panel pnlForeground;
        private System.Windows.Forms.Timer tmrIntoLogin;
        private System.Windows.Forms.Timer tmrIntoRegister;
        private System.ComponentModel.BackgroundWorker bgwCheck;
        private PictureBox pbxFondoLogo;
        private ProWork.CustomButton btnLogin;
        private UnderlinedTextBox ctbNombre;
        private enhancedPictureBox epbUser;
        private enhancedPictureBox epbPlusUser;
        private PasswordUnderlinedTextBox ctbContra;
        private PasswordUnderlinedTextBox ctbCContra;
    }
}