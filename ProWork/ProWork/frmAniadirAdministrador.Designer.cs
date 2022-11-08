namespace ProWork
{
    partial class frmAniadirAdministrador
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbtAscender = new ProWork.CustomButton();
            this.utbContra = new ProWork.PasswordUnderlinedTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(577, 118);
            this.label2.TabIndex = 1;
            this.label2.Text = "El administrador es un usuario con total control sobre la gestión de usuarios y c" +
    "ontactos.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vuestra contraseña:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbtAscender
            // 
            this.cbtAscender.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtAscender.Location = new System.Drawing.Point(105, 205);
            this.cbtAscender.Name = "cbtAscender";
            this.cbtAscender.Size = new System.Drawing.Size(366, 68);
            this.cbtAscender.TabIndex = 6;
            this.cbtAscender.Texto = "ASCENDER ⬆";
            this.cbtAscender.ButtonClick += new System.EventHandler(this.cbtAscender_Click);
            this.cbtAscender.Click += new System.EventHandler(this.cbtAscender_Click);
            // 
            // utbContra
            // 
            this.utbContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbContra.Location = new System.Drawing.Point(260, 136);
            this.utbContra.Name = "utbContra";
            this.utbContra.PlaceholderText = "";
            this.utbContra.Size = new System.Drawing.Size(290, 36);
            this.utbContra.TabIndex = 0;
            this.utbContra.txbText = "";
            this.utbContra.UsePasswordChar = true;
            // 
            // frmAniadirAdministrador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(577, 310);
            this.Controls.Add(this.utbContra);
            this.Controls.Add(this.cbtAscender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAniadirAdministrador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ascender a x a administrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAniadirAdministrador_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private Label label2;
        private Label label3;
        private CustomButton cbtAscender;
        private PasswordUnderlinedTextBox utbContra;
    }
}