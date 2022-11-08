﻿namespace ProWork
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
            this.pbPlusUser = new System.Windows.Forms.PictureBox();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.tmrIntoRegister = new System.Windows.Forms.Timer(this.components);
            this.tmrIntoLogin = new System.Windows.Forms.Timer(this.components);
            this.utbContra = new ProWork.PasswordUnderlinedTextBox();
            this.utbCContra = new ProWork.PasswordUnderlinedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlusUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // utbNombre
            // 
            this.utbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbNombre.Location = new System.Drawing.Point(119, 356);
            this.utbNombre.Name = "utbNombre";
            this.utbNombre.PlaceholderText = "Nombre";
            this.utbNombre.Size = new System.Drawing.Size(344, 45);
            this.utbNombre.TabIndex = 2;
            this.utbNombre.txbText = "";
            this.utbNombre.UsePasswordChar = false;
            // 
            // cbtCrear
            // 
            this.cbtCrear.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtCrear.Location = new System.Drawing.Point(108, 576);
            this.cbtCrear.Name = "cbtCrear";
            this.cbtCrear.Size = new System.Drawing.Size(366, 68);
            this.cbtCrear.TabIndex = 5;
            this.cbtCrear.Texto = "CREAR";
            this.cbtCrear.ButtonClick += new System.EventHandler(this.cbtCrear_Click);
            this.cbtCrear.Click += new System.EventHandler(this.cbtCrear_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLogin.Location = new System.Drawing.Point(119, 506);
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
            // pbPlusUser
            // 
            this.pbPlusUser.Image = global::ProWork.Properties.Resources.MasUsuario;
            this.pbPlusUser.Location = new System.Drawing.Point(356, 176);
            this.pbPlusUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbPlusUser.Name = "pbPlusUser";
            this.pbPlusUser.Size = new System.Drawing.Size(61, 77);
            this.pbPlusUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlusUser.TabIndex = 15;
            this.pbPlusUser.TabStop = false;
            // 
            // pbxUser
            // 
            this.pbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUser.Image = global::ProWork.Properties.Resources.Usuario;
            this.pbxUser.Location = new System.Drawing.Point(210, 108);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(174, 212);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUser.TabIndex = 14;
            this.pbxUser.TabStop = false;
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
            this.utbContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbContra.Location = new System.Drawing.Point(119, 407);
            this.utbContra.Name = "utbContra";
            this.utbContra.PlaceholderText = "Contraseña";
            this.utbContra.Size = new System.Drawing.Size(344, 45);
            this.utbContra.TabIndex = 16;
            this.utbContra.txbText = "";
            this.utbContra.UsePasswordChar = true;
            // 
            // utbCContra
            // 
            this.utbCContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbCContra.Location = new System.Drawing.Point(119, 458);
            this.utbCContra.Name = "utbCContra";
            this.utbCContra.PlaceholderText = "Confirmar Contraseña";
            this.utbCContra.Size = new System.Drawing.Size(344, 45);
            this.utbCContra.TabIndex = 17;
            this.utbCContra.txbText = "";
            this.utbCContra.UsePasswordChar = true;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTinyRegister";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrarme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTinyRegister_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlusUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UnderlinedTextBox utbNombre;
        private CustomButton cbtCrear;
        private Label lblLogin;
        private System.ComponentModel.BackgroundWorker bgwCheck;
        private PictureBox pbPlusUser;
        private PictureBox pbxUser;
        private System.Windows.Forms.Timer tmrIntoRegister;
        private System.Windows.Forms.Timer tmrIntoLogin;
        private PasswordUnderlinedTextBox utbContra;
        private PasswordUnderlinedTextBox utbCContra;
    }
}