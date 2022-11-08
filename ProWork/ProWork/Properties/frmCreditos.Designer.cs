namespace ProWork.Properties
{
    partial class frmCreditos
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
            this.epb = new ProWork.enhancedPictureBox();
            this.lbl = new System.Windows.Forms.Label();
            this.tmr60 = new System.Windows.Forms.Timer(this.components);
            this.tmr15 = new System.Windows.Forms.Timer(this.components);
            this.tmr30 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // epb
            // 
            this.epb.BackColor = System.Drawing.Color.Transparent;
            this.epb.BkgImage = global::ProWork.Properties.Resources.Logo_DSOU_azul;
            this.epb.Circle = false;
            this.epb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epb.Location = new System.Drawing.Point(12, 14);
            this.epb.Name = "epb";
            this.epb.Size = new System.Drawing.Size(225, 225);
            this.epb.TabIndex = 0;
            this.epb.Click += new System.EventHandler(this.epb_Click);
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(170)))), ((int)(((byte)(244)))));
            this.lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(243, 14);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(373, 225);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Alan Moreira";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmr60
            // 
            this.tmr60.Interval = 16;
            this.tmr60.Tick += new System.EventHandler(this.tmr60_Tick);
            // 
            // tmr15
            // 
            this.tmr15.Interval = 66;
            this.tmr15.Tick += new System.EventHandler(this.tmr15_Tick);
            // 
            // tmr30
            // 
            this.tmr30.Interval = 33;
            this.tmr30.Tick += new System.EventHandler(this.tmr30_Tick);
            // 
            // frmCreditos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(628, 252);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.epb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCreditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Créditos";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCreditos_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private enhancedPictureBox epb;
        private Label lbl;
        private System.Windows.Forms.Timer tmr60;
        private System.Windows.Forms.Timer tmr15;
        private System.Windows.Forms.Timer tmr30;
    }
}