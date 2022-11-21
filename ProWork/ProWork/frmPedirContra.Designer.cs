namespace ProWork
{
    partial class frmPedirContra
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
            this.utbContra = new ProWork.PasswordUnderlinedTextBox();
            this.cbtConfirmar = new ProWork.CustomButton();
            this.lvlVuestro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // utbContra
            // 
            this.utbContra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.utbContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.utbContra.Location = new System.Drawing.Point(273, 49);
            this.utbContra.Name = "utbContra";
            this.utbContra.PlaceholderText = "";
            this.utbContra.Size = new System.Drawing.Size(273, 36);
            this.utbContra.TabIndex = 7;
            this.utbContra.txbText = "";
            this.utbContra.UsePasswordChar = true;
            // 
            // cbtConfirmar
            // 
            this.cbtConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbtConfirmar.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbtConfirmar.Location = new System.Drawing.Point(118, 118);
            this.cbtConfirmar.Name = "cbtConfirmar";
            this.cbtConfirmar.Size = new System.Drawing.Size(349, 68);
            this.cbtConfirmar.TabIndex = 9;
            this.cbtConfirmar.TabStop = false;
            this.cbtConfirmar.Texto = "CONFIRMAR";
            // 
            // lvlVuestro
            // 
            this.lvlVuestro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lvlVuestro.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvlVuestro.ForeColor = System.Drawing.Color.White;
            this.lvlVuestro.Location = new System.Drawing.Point(13, 49);
            this.lvlVuestro.Name = "lvlVuestro";
            this.lvlVuestro.Size = new System.Drawing.Size(254, 36);
            this.lvlVuestro.TabIndex = 8;
            this.lvlVuestro.Text = "Vuestra contraseña:";
            this.lvlVuestro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmPedirContra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(560, 235);
            this.Controls.Add(this.utbContra);
            this.Controls.Add(this.cbtConfirmar);
            this.Controls.Add(this.lvlVuestro);
            this.Name = "frmPedirContra";
            this.ShowIcon = false;
            this.Text = "frmPedirContra";
            this.ResumeLayout(false);

        }

        #endregion

        private PasswordUnderlinedTextBox utbContra;
        private CustomButton cbtConfirmar;
        private Label lvlVuestro;
    }
}