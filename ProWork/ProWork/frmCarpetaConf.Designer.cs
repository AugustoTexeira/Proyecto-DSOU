namespace ProWork
{
    partial class frmCarpetaConf
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
            this.stb = new ProWork.SurroundedTextBox();
            this.cbt = new ProWork.CustomButton();
            this.SuspendLayout();
            // 
            // stb
            // 
            this.stb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.stb.fontTitulo = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stb.Location = new System.Drawing.Point(43, 15);
            this.stb.Name = "stb";
            this.stb.rtbText = "";
            this.stb.Size = new System.Drawing.Size(314, 112);
            this.stb.TabIndex = 0;
            this.stb.textTitulo = "Filtros";
            // 
            // cbt
            // 
            this.cbt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbt.Location = new System.Drawing.Point(43, 149);
            this.cbt.Name = "cbt";
            this.cbt.Size = new System.Drawing.Size(314, 54);
            this.cbt.TabIndex = 1;
            this.cbt.Texto = "CONFIRMAR";
            this.cbt.ButtonClick += new System.EventHandler(this.cbt_MouseClick);
            // 
            // frmCarpetaConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(400, 219);
            this.Controls.Add(this.cbt);
            this.Controls.Add(this.stb);
            this.MinimumSize = new System.Drawing.Size(416, 258);
            this.Name = "frmCarpetaConf";
            this.ShowIcon = false;
            this.Text = "frmCarpetaConf";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCarpetaConf_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private SurroundedTextBox stb;
        private CustomButton cbt;
    }
}