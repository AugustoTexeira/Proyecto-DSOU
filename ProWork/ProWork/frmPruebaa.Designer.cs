namespace ProWork
{
    partial class frmPruebaa
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
            this.ctlConfig = new ProWork.De_Configuración__Cristian_.ConfigContainer();
            this.SuspendLayout();
            // 
            // ctlConfig
            // 
            this.ctlConfig.AutoScroll = true;
            this.ctlConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ctlConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlConfig.Location = new System.Drawing.Point(0, 0);
            this.ctlConfig.MinimumSize = new System.Drawing.Size(736, 540);
            this.ctlConfig.Name = "ctlConfig";
            this.ctlConfig.Padding = new System.Windows.Forms.Padding(20);
            this.ctlConfig.Size = new System.Drawing.Size(812, 649);
            this.ctlConfig.TabIndex = 0;
            // 
            // frmPruebaa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(812, 649);
            this.Controls.Add(this.ctlConfig);
            this.Name = "frmPruebaa";
            this.Text = "frmPruebaa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPruebaa_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private De_Configuración__Cristian_.ConfigContainer ctlConfig;
    }
}