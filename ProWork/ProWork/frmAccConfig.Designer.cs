namespace ProWork
{
    partial class frmAccConfig
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
            this.cbtGuardar = new ProWork.CustomButton();
            this.utbNombre = new ProWork.UnderlinedTextBox();
            this.utbContra = new ProWork.UnderlinedTextBox();
            this.utbCContra = new ProWork.UnderlinedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbtGuardar
            // 
            this.cbtGuardar.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtGuardar.Location = new System.Drawing.Point(291, 203);
            this.cbtGuardar.Name = "cbtGuardar";
            this.cbtGuardar.Size = new System.Drawing.Size(219, 59);
            this.cbtGuardar.TabIndex = 4;
            this.cbtGuardar.Texto = "Guardar";
            this.cbtGuardar.ButtonClick += new System.EventHandler(this.cbtGuardar_Click);
            this.cbtGuardar.Click += new System.EventHandler(this.cbtGuardar_Click);
            // 
            // utbNombre
            // 
            this.utbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbNombre.Location = new System.Drawing.Point(341, 46);
            this.utbNombre.Name = "utbNombre";
            this.utbNombre.PlaceholderText = "Pepito Gonzales";
            this.utbNombre.Size = new System.Drawing.Size(377, 36);
            this.utbNombre.TabIndex = 1;
            this.utbNombre.txbText = "";
            this.utbNombre.UsePasswordChar = false;
            // 
            // utbContra
            // 
            this.utbContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbContra.Location = new System.Drawing.Point(341, 88);
            this.utbContra.Name = "utbContra";
            this.utbContra.PlaceholderText = "Vacío: Contraseña anterior";
            this.utbContra.Size = new System.Drawing.Size(377, 36);
            this.utbContra.TabIndex = 2;
            this.utbContra.txbText = "";
            this.utbContra.UsePasswordChar = true;
            // 
            // utbCContra
            // 
            this.utbCContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbCContra.Location = new System.Drawing.Point(341, 130);
            this.utbCContra.Name = "utbCContra";
            this.utbCContra.PlaceholderText = "Vacío: Contraseña anterior";
            this.utbCContra.Size = new System.Drawing.Size(377, 36);
            this.utbCContra.TabIndex = 3;
            this.utbCContra.txbText = "";
            this.utbCContra.UsePasswordChar = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(139, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirmar Contraseña:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAccConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.utbCContra);
            this.Controls.Add(this.utbContra);
            this.Controls.Add(this.utbNombre);
            this.Controls.Add(this.cbtGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAccConfig";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "⚙️ Configuración";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAccConfig_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton cbtGuardar;
        private UnderlinedTextBox utbNombre;
        private UnderlinedTextBox utbContra;
        private UnderlinedTextBox utbCContra;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}