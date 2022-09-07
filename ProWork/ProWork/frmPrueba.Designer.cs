namespace ProWork
{
    partial class frmPrueba
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
            this.archivo1 = new ProWork.Archivo();
            this.fileHolder1 = new ProWork.FileHolder();
            this.SuspendLayout();
            // 
            // archivo1
            // 
            this.archivo1.BackColor = System.Drawing.Color.Purple;
            this.archivo1.Location = new System.Drawing.Point(0, 0);
            this.archivo1.Name = "archivo1";
            this.archivo1.Size = new System.Drawing.Size(100, 100);
            this.archivo1.TabIndex = 0;
            // 
            // fileHolder1
            // 
            this.fileHolder1.AutoScroll = true;
            this.fileHolder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileHolder1.Location = new System.Drawing.Point(0, 0);
            this.fileHolder1.Name = "fileHolder1";
            this.fileHolder1.Size = new System.Drawing.Size(702, 487);
            this.fileHolder1.TabIndex = 0;
            // 
            // frmPrueba
            // 
            this.ClientSize = new System.Drawing.Size(702, 487);
            this.Controls.Add(this.fileHolder1);
            this.Name = "frmPrueba";
            this.Load += new System.EventHandler(this.frmPrueba_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Archivo archivo1;
        private FileHolder fileHolder1;
    }
}