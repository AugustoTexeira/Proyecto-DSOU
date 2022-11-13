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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lvlVuestro = new System.Windows.Forms.Label();
            this.cbtAscender = new ProWork.CustomButton();
            this.utbContra = new ProWork.PasswordUnderlinedTextBox();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblInfo.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(577, 118);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "El administrador es un usuario con total control sobre la gestión de usuarios y c" +
    "ontactos.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvlVuestro
            // 
            this.lvlVuestro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lvlVuestro.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvlVuestro.ForeColor = System.Drawing.Color.White;
            this.lvlVuestro.Location = new System.Drawing.Point(0, 136);
            this.lvlVuestro.Name = "lvlVuestro";
            this.lvlVuestro.Size = new System.Drawing.Size(254, 36);
            this.lvlVuestro.TabIndex = 3;
            this.lvlVuestro.Text = "Vuestra contraseña:";
            this.lvlVuestro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbtAscender
            // 
            this.cbtAscender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbtAscender.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtAscender.Location = new System.Drawing.Point(105, 205);
            this.cbtAscender.Name = "cbtAscender";
            this.cbtAscender.Size = new System.Drawing.Size(366, 68);
            this.cbtAscender.TabIndex = 6;
            this.cbtAscender.TabStop = false;
            this.cbtAscender.Texto = "ASCENDER ⬆";
            this.cbtAscender.ButtonClick += new System.EventHandler(this.cbtAscender_Click);
            this.cbtAscender.Click += new System.EventHandler(this.cbtAscender_Click);
            // 
            // utbContra
            // 
            this.utbContra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.utbContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbContra.Location = new System.Drawing.Point(260, 136);
            this.utbContra.Name = "utbContra";
            this.utbContra.PlaceholderText = "";
            this.utbContra.Size = new System.Drawing.Size(290, 36);
            this.utbContra.TabIndex = 0;
            this.utbContra.txbText = "";
            this.utbContra.UsePasswordChar = true;
            this.utbContra.EnterPressed += new System.EventHandler(this.cbtAscender_Click);
            // 
            // frmAniadirAdministrador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(577, 310);
            this.Controls.Add(this.utbContra);
            this.Controls.Add(this.cbtAscender);
            this.Controls.Add(this.lvlVuestro);
            this.Controls.Add(this.lblInfo);
            this.MinimumSize = new System.Drawing.Size(595, 357);
            this.Name = "frmAniadirAdministrador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ascender a x a administrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAniadirAdministrador_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private Label lblInfo;
        private Label lvlVuestro;
        private CustomButton cbtAscender;
        private PasswordUnderlinedTextBox utbContra;
    }
}