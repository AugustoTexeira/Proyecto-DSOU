namespace ProWork.De_Configuración__Cristian_
{
    partial class ConfigContainer
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.aclCuentas = new ProWork.AccountList();
            this.cbtAnadir = new ProWork.CustomButton();
            this.lblConfig = new System.Windows.Forms.Label();
            this.pbxOscuro = new System.Windows.Forms.PictureBox();
            this.lblOscuro = new System.Windows.Forms.Label();
            this.lblClaro = new System.Windows.Forms.Label();
            this.pbxClaro = new System.Windows.Forms.PictureBox();
            this.lblPersonalizado = new System.Windows.Forms.Label();
            this.pbxPersonalizado = new System.Windows.Forms.PictureBox();
            this.lblCuentas = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOscuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClaro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonalizado)).BeginInit();
            this.SuspendLayout();
            // 
            // aclCuentas
            // 
            this.aclCuentas.AutoScroll = true;
            this.aclCuentas.BackColor = System.Drawing.Color.Gray;
            this.aclCuentas.Location = new System.Drawing.Point(20, 401);
            this.aclCuentas.Name = "aclCuentas";
            this.aclCuentas.Size = new System.Drawing.Size(1129, 195);
            this.aclCuentas.TabIndex = 0;
            // 
            // cbtAnadir
            // 
            this.cbtAnadir.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbtAnadir.Location = new System.Drawing.Point(20, 602);
            this.cbtAnadir.Name = "cbtAnadir";
            this.cbtAnadir.Size = new System.Drawing.Size(140, 39);
            this.cbtAnadir.TabIndex = 1;
            this.cbtAnadir.Texto = "Añadir   ➕";
            this.cbtAnadir.ButtonClick += new System.EventHandler(this.cbtAnadir_Click);
            this.cbtAnadir.Click += new System.EventHandler(this.cbtAnadir_Click);
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Font = new System.Drawing.Font("Raleway", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfig.ForeColor = System.Drawing.Color.White;
            this.lblConfig.Location = new System.Drawing.Point(23, 20);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(291, 55);
            this.lblConfig.TabIndex = 2;
            this.lblConfig.Text = "Configuración";
            // 
            // pbxOscuro
            // 
            this.pbxOscuro.BackColor = System.Drawing.Color.Transparent;
            this.pbxOscuro.BackgroundImage = global::ProWork.Properties.Resources.Tema_oscuro;
            this.pbxOscuro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxOscuro.Location = new System.Drawing.Point(20, 151);
            this.pbxOscuro.Margin = new System.Windows.Forms.Padding(0);
            this.pbxOscuro.Name = "pbxOscuro";
            this.pbxOscuro.Size = new System.Drawing.Size(178, 131);
            this.pbxOscuro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxOscuro.TabIndex = 4;
            this.pbxOscuro.TabStop = false;
            this.pbxOscuro.Click += new System.EventHandler(this.pbxOscuro_Click);
            this.pbxOscuro.MouseEnter += new System.EventHandler(this.pbxOscuro_MouseEnter);
            this.pbxOscuro.MouseLeave += new System.EventHandler(this.pbxOscuro_MouseLeave);
            // 
            // lblOscuro
            // 
            this.lblOscuro.BackColor = System.Drawing.Color.Transparent;
            this.lblOscuro.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOscuro.ForeColor = System.Drawing.Color.White;
            this.lblOscuro.Location = new System.Drawing.Point(20, 282);
            this.lblOscuro.Margin = new System.Windows.Forms.Padding(0);
            this.lblOscuro.Name = "lblOscuro";
            this.lblOscuro.Size = new System.Drawing.Size(178, 39);
            this.lblOscuro.TabIndex = 7;
            this.lblOscuro.Text = "Oscuro";
            this.lblOscuro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOscuro.Click += new System.EventHandler(this.pbxOscuro_Click);
            this.lblOscuro.MouseEnter += new System.EventHandler(this.pbxOscuro_MouseEnter);
            this.lblOscuro.MouseLeave += new System.EventHandler(this.pbxOscuro_MouseLeave);
            // 
            // lblClaro
            // 
            this.lblClaro.BackColor = System.Drawing.Color.Transparent;
            this.lblClaro.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClaro.ForeColor = System.Drawing.Color.White;
            this.lblClaro.Location = new System.Drawing.Point(515, 282);
            this.lblClaro.Margin = new System.Windows.Forms.Padding(0);
            this.lblClaro.Name = "lblClaro";
            this.lblClaro.Size = new System.Drawing.Size(178, 39);
            this.lblClaro.TabIndex = 11;
            this.lblClaro.Text = "Claro";
            this.lblClaro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClaro.Click += new System.EventHandler(this.pbxClaro_Click);
            this.lblClaro.MouseEnter += new System.EventHandler(this.pbxClaro_MouseEnter);
            this.lblClaro.MouseLeave += new System.EventHandler(this.pbxClaro_MouseLeave);
            // 
            // pbxClaro
            // 
            this.pbxClaro.BackColor = System.Drawing.Color.Transparent;
            this.pbxClaro.BackgroundImage = global::ProWork.Properties.Resources.Tema_claro;
            this.pbxClaro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxClaro.Location = new System.Drawing.Point(515, 151);
            this.pbxClaro.Margin = new System.Windows.Forms.Padding(0);
            this.pbxClaro.Name = "pbxClaro";
            this.pbxClaro.Size = new System.Drawing.Size(178, 131);
            this.pbxClaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClaro.TabIndex = 10;
            this.pbxClaro.TabStop = false;
            this.pbxClaro.Click += new System.EventHandler(this.pbxClaro_Click);
            this.pbxClaro.MouseEnter += new System.EventHandler(this.pbxClaro_MouseEnter);
            this.pbxClaro.MouseLeave += new System.EventHandler(this.pbxClaro_MouseLeave);
            // 
            // lblPersonalizado
            // 
            this.lblPersonalizado.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonalizado.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPersonalizado.ForeColor = System.Drawing.Color.White;
            this.lblPersonalizado.Location = new System.Drawing.Point(979, 282);
            this.lblPersonalizado.Margin = new System.Windows.Forms.Padding(0);
            this.lblPersonalizado.Name = "lblPersonalizado";
            this.lblPersonalizado.Size = new System.Drawing.Size(178, 39);
            this.lblPersonalizado.TabIndex = 13;
            this.lblPersonalizado.Text = "Personalizado";
            this.lblPersonalizado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPersonalizado.MouseEnter += new System.EventHandler(this.pbxPersonalizado_MouseEnter);
            this.lblPersonalizado.MouseLeave += new System.EventHandler(this.pbxPersonalizado_MouseLeave);
            // 
            // pbxPersonalizado
            // 
            this.pbxPersonalizado.BackColor = System.Drawing.Color.Transparent;
            this.pbxPersonalizado.BackgroundImage = global::ProWork.Properties.Resources.Personalizado;
            this.pbxPersonalizado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxPersonalizado.Location = new System.Drawing.Point(979, 151);
            this.pbxPersonalizado.Margin = new System.Windows.Forms.Padding(0);
            this.pbxPersonalizado.Name = "pbxPersonalizado";
            this.pbxPersonalizado.Size = new System.Drawing.Size(178, 131);
            this.pbxPersonalizado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPersonalizado.TabIndex = 12;
            this.pbxPersonalizado.TabStop = false;
            this.pbxPersonalizado.Click += new System.EventHandler(this.pbxPersonalizado_Click);
            this.pbxPersonalizado.MouseEnter += new System.EventHandler(this.pbxPersonalizado_MouseEnter);
            this.pbxPersonalizado.MouseLeave += new System.EventHandler(this.pbxPersonalizado_MouseLeave);
            // 
            // lblCuentas
            // 
            this.lblCuentas.AutoSize = true;
            this.lblCuentas.Font = new System.Drawing.Font("Raleway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuentas.ForeColor = System.Drawing.Color.White;
            this.lblCuentas.Location = new System.Drawing.Point(20, 359);
            this.lblCuentas.Name = "lblCuentas";
            this.lblCuentas.Size = new System.Drawing.Size(128, 39);
            this.lblCuentas.TabIndex = 14;
            this.lblCuentas.Text = "Cuentas:";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Raleway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTema.ForeColor = System.Drawing.Color.White;
            this.lblTema.Location = new System.Drawing.Point(26, 99);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(93, 39);
            this.lblTema.TabIndex = 3;
            this.lblTema.Text = "Tema:";
            // 
            // ConfigContainer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblCuentas);
            this.Controls.Add(this.lblPersonalizado);
            this.Controls.Add(this.pbxPersonalizado);
            this.Controls.Add(this.lblClaro);
            this.Controls.Add(this.pbxClaro);
            this.Controls.Add(this.lblOscuro);
            this.Controls.Add(this.pbxOscuro);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblConfig);
            this.Controls.Add(this.cbtAnadir);
            this.Controls.Add(this.aclCuentas);
            this.MinimumSize = new System.Drawing.Size(736, 540);
            this.Name = "ConfigContainer";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1238, 761);
            this.Load += new System.EventHandler(this.ConfigContainer_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ConfigContainer_Paint);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.ConfigContainer_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.pbxOscuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClaro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonalizado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomButton cbtAnadir;
        private Label lblConfig;
        private PictureBox pbxOscuro;
        private Label lblOscuro;
        private Label lblClaro;
        private PictureBox pbxClaro;
        private Label lblPersonalizado;
        private PictureBox pbxPersonalizado;
        private Label lblCuentas;
        private Label lblTema;
        public AccountList aclCuentas;
    }
}
