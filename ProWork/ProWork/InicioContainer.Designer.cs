namespace ProWork
{
    partial class InicioContainer
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
            this.btnCrear = new ProWork.CustomButton();
            this.epbNuevoProyecto = new ProWork.enhancedPictureBox();
            this.lblArrastre = new System.Windows.Forms.Label();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.uTxtNombreProyecto = new ProWork.UnderlinedTextBox();
            this.uTxtTipoProyecto = new ProWork.UnderlinedTextBox();
            this.pnl = new System.Windows.Forms.Panel();
            this.btnCancelar = new ProWork.CustomButton();
            this.blsFechas = new ProWork.boringList();
            this.blsCarpeta = new ProWork.boringList();
            this.customButton2 = new ProWork.CustomButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.sTxtDescripcion = new ProWork.SurroundedTextBox();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrear.Location = new System.Drawing.Point(693, 656);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(295, 63);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.TabStop = false;
            this.btnCrear.Texto = "Crear Proyecto";
            this.btnCrear.ButtonClick += new System.EventHandler(this.crearbtn_Click);
            // 
            // epbNuevoProyecto
            // 
            this.epbNuevoProyecto.AllowDrop = true;
            this.epbNuevoProyecto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.epbNuevoProyecto.BackColor = System.Drawing.Color.Transparent;
            this.epbNuevoProyecto.BkgImage = global::ProWork.Properties.Resources.InicioProyecto;
            this.epbNuevoProyecto.Circle = false;
            this.epbNuevoProyecto.Location = new System.Drawing.Point(448, 273);
            this.epbNuevoProyecto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.epbNuevoProyecto.Name = "epbNuevoProyecto";
            this.epbNuevoProyecto.Size = new System.Drawing.Size(125, 121);
            this.epbNuevoProyecto.TabIndex = 1;
            this.epbNuevoProyecto.TabStop = false;
            this.epbNuevoProyecto.DragDrop += new System.Windows.Forms.DragEventHandler(this.epbNuevoProyecto_DragDrop);
            this.epbNuevoProyecto.DragEnter += new System.Windows.Forms.DragEventHandler(this.epbNuevoProyecto_DragDropEnter);
            // 
            // lblArrastre
            // 
            this.lblArrastre.AllowDrop = true;
            this.lblArrastre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArrastre.BackColor = System.Drawing.Color.Transparent;
            this.lblArrastre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArrastre.ForeColor = System.Drawing.Color.White;
            this.lblArrastre.Location = new System.Drawing.Point(204, 414);
            this.lblArrastre.Name = "lblArrastre";
            this.lblArrastre.Size = new System.Drawing.Size(613, 68);
            this.lblArrastre.TabIndex = 2;
            this.lblArrastre.Text = " Arrastre los archivos aquí o presione el botón de crear\r\npara crear un nuevo pro" +
    "yecto ";
            this.lblArrastre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblArrastre.DragDrop += new System.Windows.Forms.DragEventHandler(this.epbNuevoProyecto_DragDrop);
            this.lblArrastre.DragEnter += new System.Windows.Forms.DragEventHandler(this.epbNuevoProyecto_DragDropEnter);
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.BackColor = System.Drawing.Color.Transparent;
            this.lblProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProyecto.ForeColor = System.Drawing.Color.White;
            this.lblProyecto.Location = new System.Drawing.Point(17, 19);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(254, 37);
            this.lblProyecto.TabIndex = 3;
            this.lblProyecto.Text = "Nuevo proyecto";
            this.lblProyecto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uTxtNombreProyecto
            // 
            this.uTxtNombreProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uTxtNombreProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.uTxtNombreProyecto.Location = new System.Drawing.Point(17, 98);
            this.uTxtNombreProyecto.Name = "uTxtNombreProyecto";
            this.uTxtNombreProyecto.PlaceholderText = "Nombre del proyecto";
            this.uTxtNombreProyecto.Size = new System.Drawing.Size(649, 30);
            this.uTxtNombreProyecto.TabIndex = 4;
            this.uTxtNombreProyecto.txbText = "";
            this.uTxtNombreProyecto.UsePasswordChar = false;
            // 
            // uTxtTipoProyecto
            // 
            this.uTxtTipoProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uTxtTipoProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.uTxtTipoProyecto.Location = new System.Drawing.Point(17, 183);
            this.uTxtTipoProyecto.Name = "uTxtTipoProyecto";
            this.uTxtTipoProyecto.PlaceholderText = "Tipo del proyecto";
            this.uTxtTipoProyecto.Size = new System.Drawing.Size(649, 30);
            this.uTxtTipoProyecto.TabIndex = 5;
            this.uTxtTipoProyecto.txbText = "";
            this.uTxtTipoProyecto.UsePasswordChar = false;
            // 
            // pnl
            // 
            this.pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl.Controls.Add(this.btnCancelar);
            this.pnl.Controls.Add(this.blsFechas);
            this.pnl.Controls.Add(this.blsCarpeta);
            this.pnl.Controls.Add(this.customButton2);
            this.pnl.Controls.Add(this.dateTimePicker1);
            this.pnl.Controls.Add(this.uTxtNombreProyecto);
            this.pnl.Controls.Add(this.sTxtDescripcion);
            this.pnl.Controls.Add(this.uTxtTipoProyecto);
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1021, 755);
            this.pnl.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(616, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Texto = "X";
            this.btnCancelar.ButtonClick += new System.EventHandler(this.btnCancelar_ButtonClick);
            // 
            // blsFechas
            // 
            this.blsFechas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.blsFechas.AutoScroll = true;
            this.blsFechas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blsFechas.Location = new System.Drawing.Point(693, 398);
            this.blsFechas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blsFechas.Name = "blsFechas";
            this.blsFechas.Size = new System.Drawing.Size(295, 251);
            this.blsFechas.TabIndex = 11;
            // 
            // blsCarpeta
            // 
            this.blsCarpeta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blsCarpeta.AutoScroll = true;
            this.blsCarpeta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blsCarpeta.Location = new System.Drawing.Point(693, 19);
            this.blsCarpeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blsCarpeta.Name = "blsCarpeta";
            this.blsCarpeta.Size = new System.Drawing.Size(295, 278);
            this.blsCarpeta.TabIndex = 10;
            this.blsCarpeta.gearClicked += new System.EventHandler(this.blsCarpeta_gearClicked);
            // 
            // customButton2
            // 
            this.customButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customButton2.Location = new System.Drawing.Point(693, 302);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(295, 63);
            this.customButton2.TabIndex = 9;
            this.customButton2.TabStop = false;
            this.customButton2.Texto = "Crear carpeta";
            this.customButton2.ButtonClick += new System.EventHandler(this.customButton2_ButtonClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(693, 370);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 23);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // sTxtDescripcion
            // 
            this.sTxtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sTxtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.sTxtDescripcion.fontTitulo = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sTxtDescripcion.Location = new System.Drawing.Point(17, 243);
            this.sTxtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sTxtDescripcion.Name = "sTxtDescripcion";
            this.sTxtDescripcion.rtbText = "";
            this.sTxtDescripcion.Size = new System.Drawing.Size(649, 406);
            this.sTxtDescripcion.TabIndex = 7;
            this.sTxtDescripcion.textTitulo = "Descripción";
            // 
            // InicioContainer
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.epbNuevoProyecto);
            this.Controls.Add(this.lblArrastre);
            this.Name = "InicioContainer";
            this.Size = new System.Drawing.Size(1021, 755);
            this.Load += new System.EventHandler(this.InicioContainer_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.epbNuevoProyecto_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.epbNuevoProyecto_DragDropEnter);
            this.pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton btnCrear;
        private enhancedPictureBox epbNuevoProyecto;
        private Label lblArrastre;
        private Label lblProyecto;
        private UnderlinedTextBox uTxtNombreProyecto;
        private UnderlinedTextBox uTxtTipoProyecto;
        private Panel pnl;
        private CustomButton customButton2;
        private DateTimePicker dateTimePicker1;
        private SurroundedTextBox sTxtDescripcion;
        private boringList blsFechas;
        private boringList blsCarpeta;
        private CustomButton btnCancelar;
    }
}
