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
            this.pyc = new ProWork.ProyectosContainer();
            this.SuspendLayout();
            // 
            // pyc
            // 
            this.pyc.BackColor = System.Drawing.SystemColors.ControlText;
            this.pyc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pyc.Location = new System.Drawing.Point(0, 0);
            this.pyc.Name = "pyc";
            this.pyc.Size = new System.Drawing.Size(812, 649);
            this.pyc.TabIndex = 0;
            // 
            // frmPruebaa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(812, 649);
            this.Controls.Add(this.pyc);
            this.Name = "frmPruebaa";
            this.Text = "frmPruebaa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPruebaa_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private ProyectosContainer pyc;
    }
}