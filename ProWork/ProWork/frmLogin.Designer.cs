﻿namespace ProWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.tmrSubrayado = new System.Windows.Forms.Timer(this.components);
            this.btnSwap = new System.Windows.Forms.Button();
            this.pnlForeground = new System.Windows.Forms.Panel();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.btnContra = new System.Windows.Forms.Button();
            this.btnCContra = new System.Windows.Forms.Button();
            this.tmrIntoLogin = new System.Windows.Forms.Timer(this.components);
            this.tmrIntoRegister = new System.Windows.Forms.Timer(this.components);
            this.bgwCheck = new System.ComponentModel.BackgroundWorker();
            this.ctbNombre = new ProWork.CustomTextBox();
            this.ctbCContra = new ProWork.CustomTextBox();
            this.ctbContra = new ProWork.CustomTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlForeground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = global::ProWork.Properties.Resources.Fondo_boton;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(808, 304);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(262, 46);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Crear";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tmrSubrayado
            // 
            this.tmrSubrayado.Interval = 16;
            this.tmrSubrayado.Tick += new System.EventHandler(this.tmrSubrayado_Tick);
            // 
            // btnSwap
            // 
            this.btnSwap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.btnSwap.FlatAppearance.BorderSize = 0;
            this.btnSwap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSwap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwap.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSwap.Location = new System.Drawing.Point(808, 355);
            this.btnSwap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(214, 22);
            this.btnSwap.TabIndex = 0;
            this.btnSwap.Text = "¿Tienes una cuenta? Inicia sesión";
            this.btnSwap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSwap.UseVisualStyleBackColor = false;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // pnlForeground
            // 
            this.pnlForeground.BackColor = System.Drawing.Color.Black;
            this.pnlForeground.Controls.Add(this.pictureBox1);
            this.pnlForeground.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlForeground.Location = new System.Drawing.Point(0, 0);
            this.pnlForeground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlForeground.Name = "pnlForeground";
            this.pnlForeground.Size = new System.Drawing.Size(772, 505);
            this.pnlForeground.TabIndex = 8;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // pbxUser
            // 
            this.pbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUser.Image = global::ProWork.Properties.Resources.Icono_Inicio_de_sesion;
            this.pbxUser.Location = new System.Drawing.Point(900, 62);
            this.pbxUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(91, 102);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUser.TabIndex = 9;
            this.pbxUser.TabStop = false;
            // 
            // btnContra
            // 
            this.btnContra.FlatAppearance.BorderSize = 0;
            this.btnContra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContra.Image = global::ProWork.Properties.Resources.ojitosi321;
            this.btnContra.Location = new System.Drawing.Point(1051, 220);
            this.btnContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContra.Name = "btnContra";
            this.btnContra.Size = new System.Drawing.Size(32, 27);
            this.btnContra.TabIndex = 3;
            this.btnContra.UseVisualStyleBackColor = true;
            this.btnContra.Click += new System.EventHandler(this.pbxOContra_Click);
            this.btnContra.Paint += new System.Windows.Forms.PaintEventHandler(this.btnContra_Paint);
            // 
            // btnCContra
            // 
            this.btnCContra.FlatAppearance.BorderSize = 0;
            this.btnCContra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnCContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCContra.Image = global::ProWork.Properties.Resources.ojitosi321;
            this.btnCContra.Location = new System.Drawing.Point(1051, 262);
            this.btnCContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCContra.Name = "btnCContra";
            this.btnCContra.Size = new System.Drawing.Size(32, 27);
            this.btnCContra.TabIndex = 5;
            this.btnCContra.UseVisualStyleBackColor = true;
            this.btnCContra.Click += new System.EventHandler(this.btnCContra_Click);
            this.btnCContra.Paint += new System.Windows.Forms.PaintEventHandler(this.btnCContra_Paint);
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
            // ctbNombre
            // 
            this.ctbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.ctbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctbNombre.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ctbNombre.ForeColor = System.Drawing.Color.White;
            this.ctbNombre.Location = new System.Drawing.Point(792, 179);
            this.ctbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctbNombre.Name = "ctbNombre";
            this.ctbNombre.PlaceholderText = "Nombre";
            this.ctbNombre.Size = new System.Drawing.Size(291, 29);
            this.ctbNombre.TabIndex = 10;
            this.ctbNombre.Enter += new System.EventHandler(this.txb_Enter);
            this.ctbNombre.Leave += new System.EventHandler(this.txb_Leave);
            // 
            // ctbCContra
            // 
            this.ctbCContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.ctbCContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctbCContra.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ctbCContra.ForeColor = System.Drawing.Color.White;
            this.ctbCContra.Location = new System.Drawing.Point(792, 262);
            this.ctbCContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctbCContra.Name = "ctbCContra";
            this.ctbCContra.PlaceholderText = "Confirmar contraseña";
            this.ctbCContra.Size = new System.Drawing.Size(291, 29);
            this.ctbCContra.TabIndex = 3;
            this.ctbCContra.Enter += new System.EventHandler(this.txb_Enter);
            this.ctbCContra.Leave += new System.EventHandler(this.txb_Leave);
            // 
            // ctbContra
            // 
            this.ctbContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.ctbContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctbContra.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ctbContra.ForeColor = System.Drawing.Color.White;
            this.ctbContra.Location = new System.Drawing.Point(792, 220);
            this.ctbContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctbContra.Name = "ctbContra";
            this.ctbContra.PlaceholderText = "Contraseña";
            this.ctbContra.Size = new System.Drawing.Size(291, 29);
            this.ctbContra.TabIndex = 12;
            this.ctbContra.Enter += new System.EventHandler(this.txb_Enter);
            this.ctbContra.Leave += new System.EventHandler(this.txb_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(239, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1104, 505);
            this.Controls.Add(this.ctbNombre);
            this.Controls.Add(this.btnCContra);
            this.Controls.Add(this.btnContra);
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.pnlForeground);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.ctbContra);
            this.Controls.Add(this.ctbCContra);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prowork";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmLogin_Paint);
            this.pnlForeground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnLogin;
        private System.Windows.Forms.Timer tmrSubrayado;
        private Button btnSwap;
        private Panel pnlForeground;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private PictureBox pbxUser;
        private Button btnContra;
        private Button btnCContra;
        private System.Windows.Forms.Timer tmrIntoLogin;
        private System.Windows.Forms.Timer tmrIntoRegister;
        private System.ComponentModel.BackgroundWorker bgwCheck;
        private CustomTextBox ctbNombre;
        private CustomTextBox ctbCContra;
        private CustomTextBox ctbContra;
        private PictureBox pictureBox1;
    }
}