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
            this.cbtAnadir = new ProWork.CustomButton();
            this.lblConfig = new System.Windows.Forms.Label();
            this.pbxOscuro = new System.Windows.Forms.PictureBox();
            this.lblOscuro = new System.Windows.Forms.Label();
            this.lblClaro = new System.Windows.Forms.Label();
            this.pbxClaro = new System.Windows.Forms.PictureBox();
            this.lblCuentas = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.lst = new ProWork.List();
            this.lblDudas = new System.Windows.Forms.LinkLabel();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.grf = new ProWork.Grafica();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOscuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClaro)).BeginInit();
            this.SuspendLayout();
            // 
            // cbtAnadir
            // 
            this.cbtAnadir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbtAnadir.Font = new System.Drawing.Font("Raleway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbtAnadir.Location = new System.Drawing.Point(20, 735);
            this.cbtAnadir.Margin = new System.Windows.Forms.Padding(20);
            this.cbtAnadir.Name = "cbtAnadir";
            this.cbtAnadir.Size = new System.Drawing.Size(673, 55);
            this.cbtAnadir.TabIndex = 1;
            this.cbtAnadir.Texto = "Cuenta nueva  ➕";
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
            // lst
            // 
            this.lst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst.AutoScroll = true;
            this.lst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.lst.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lst.Location = new System.Drawing.Point(20, 401);
            this.lst.Margin = new System.Windows.Forms.Padding(6, 6, 6, 20);
            this.lst.mode = ((byte)(0));
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(673, 318);
            this.lst.TabIndex = 15;
            this.lst.itemEnterHover += new System.EventHandler(this.lst_itemEnterHover);
            this.lst.gearClicked += new System.EventHandler(this.lst_gearClicked);
            this.lst.trashClicked += new System.EventHandler(this.lst_trashClicked);
            this.lst.itemClicked += new System.Windows.Forms.MouseEventHandler(this.lst_itemClicked);
            // 
            // lblDudas
            // 
            this.lblDudas.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.lblDudas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDudas.AutoSize = true;
            this.lblDudas.BackColor = System.Drawing.Color.Transparent;
            this.lblDudas.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(49)))), ((int)(((byte)(247)))));
            this.lblDudas.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDudas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(49)))), ((int)(((byte)(247)))));
            this.lblDudas.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblDudas.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(49)))), ((int)(((byte)(247)))));
            this.lblDudas.Location = new System.Drawing.Point(855, 39);
            this.lblDudas.Name = "lblDudas";
            this.lblDudas.Size = new System.Drawing.Size(250, 32);
            this.lblDudas.TabIndex = 16;
            this.lblDudas.TabStop = true;
            this.lblDudas.Text = "¿Dudas? Contáctanos.";
            this.lblDudas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDudas.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(49)))), ((int)(((byte)(247)))));
            this.lblDudas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDudas_LinkClicked);
            // 
            // dtpStart
            // 
            this.dtpStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.dtpStart.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.dtpStart.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.dtpStart.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpStart.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.dtpStart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpStart.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(739, 401);
            this.dtpStart.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(115, 25);
            this.dtpStart.TabIndex = 18;
            this.dtpStart.Value = new System.DateTime(2022, 1, 1, 11, 3, 0, 0);
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // grf
            // 
            this.grf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grf.Downwards = false;
            this.grf.highlightDots = false;
            this.grf.isBarGraph = false;
            this.grf.Location = new System.Drawing.Point(739, 432);
            this.grf.Name = "grf";
            this.grf.onlyDots = false;
            this.grf.Points = new System.Drawing.Point[] {
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(5, 15),
        new System.Drawing.Point(8, 4)};
            this.grf.realCoordsOfPoints = new System.Drawing.Point[] {
        new System.Drawing.Point(0, 358),
        new System.Drawing.Point(182, 0),
        new System.Drawing.Point(291, 262)};
            this.grf.Scale = new System.Drawing.Size(10, 15);
            this.grf.Size = new System.Drawing.Size(364, 358);
            this.grf.TabIndex = 19;
            this.grf.XOffset = 0;
            this.grf.YOffset = 0;
            this.grf.Load += new System.EventHandler(this.grf_Load_1);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.dtpEnd.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.dtpEnd.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.dtpEnd.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpEnd.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.dtpEnd.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(993, 401);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(110, 25);
            this.dtpEnd.TabIndex = 20;
            this.dtpEnd.Value = new System.DateTime(2022, 11, 10, 0, 0, 0, 0);
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(739, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 39);
            this.label1.TabIndex = 21;
            this.label1.Text = "Actividad:";
            // 
            // ConfigContainer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblDudas);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.lblCuentas);
            this.Controls.Add(this.lblClaro);
            this.Controls.Add(this.pbxClaro);
            this.Controls.Add(this.lblOscuro);
            this.Controls.Add(this.pbxOscuro);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblConfig);
            this.Controls.Add(this.cbtAnadir);
            this.Controls.Add(this.grf);
            this.DoubleBuffered = true;
            this.Name = "ConfigContainer";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1134, 810);
            this.Load += new System.EventHandler(this.ConfigContainer_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ConfigContainer_Paint);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.ConfigContainer_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.pbxOscuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClaro)).EndInit();
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
        private Label lblCuentas;
        private Label lblTema;
        private List lst;
        private LinkLabel lblDudas;
        private DateTimePicker dtpStart;
        private Grafica grf;
        private DateTimePicker dtpEnd;
        private Label label1;
    }
}
