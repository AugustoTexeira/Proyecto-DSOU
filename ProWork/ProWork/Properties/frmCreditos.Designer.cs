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
            this.tmr60 = new System.Windows.Forms.Timer(this.components);
            this.tmr15 = new System.Windows.Forms.Timer(this.components);
            this.tmr30 = new System.Windows.Forms.Timer(this.components);
            this.linksAlan = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkPinto = new System.Windows.Forms.LinkLabel();
            this.linkAugusto = new System.Windows.Forms.LinkLabel();
            this.linkCristian = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // epb
            // 
            this.epb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.epb.BackColor = System.Drawing.Color.Transparent;
            this.epb.BkgImage = global::ProWork.Properties.Resources.Logo_DSOU_azul;
            this.epb.Circle = false;
            this.epb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.epb.Location = new System.Drawing.Point(12, 14);
            this.epb.Name = "epb";
            this.epb.Size = new System.Drawing.Size(225, 225);
            this.epb.TabIndex = 0;
            this.epb.Click += new System.EventHandler(this.epb_Click);
            this.epb.DoubleClick += new System.EventHandler(this.epb_DoubleClick);
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
            // linksAlan
            // 
            this.linksAlan.ActiveLinkColor = System.Drawing.Color.White;
            this.linksAlan.AutoSize = true;
            this.linksAlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(170)))), ((int)(((byte)(244)))));
            this.linksAlan.DisabledLinkColor = System.Drawing.Color.White;
            this.linksAlan.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linksAlan.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linksAlan.LinkColor = System.Drawing.Color.White;
            this.linksAlan.Location = new System.Drawing.Point(0, 12);
            this.linksAlan.Name = "linksAlan";
            this.linksAlan.Size = new System.Drawing.Size(201, 42);
            this.linksAlan.TabIndex = 2;
            this.linksAlan.TabStop = true;
            this.linksAlan.Text = "Alan Moreira";
            this.linksAlan.VisitedLinkColor = System.Drawing.Color.White;
            this.linksAlan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linksAlan_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(170)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.linkPinto);
            this.panel1.Controls.Add(this.linkAugusto);
            this.panel1.Controls.Add(this.linkCristian);
            this.panel1.Controls.Add(this.linksAlan);
            this.panel1.Location = new System.Drawing.Point(243, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 225);
            this.panel1.TabIndex = 3;
            // 
            // linkPinto
            // 
            this.linkPinto.ActiveLinkColor = System.Drawing.Color.White;
            this.linkPinto.AutoSize = true;
            this.linkPinto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(170)))), ((int)(((byte)(244)))));
            this.linkPinto.DisabledLinkColor = System.Drawing.Color.White;
            this.linkPinto.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkPinto.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkPinto.LinkColor = System.Drawing.Color.White;
            this.linkPinto.Location = new System.Drawing.Point(0, 112);
            this.linkPinto.Name = "linkPinto";
            this.linkPinto.Size = new System.Drawing.Size(187, 42);
            this.linkPinto.TabIndex = 5;
            this.linkPinto.TabStop = true;
            this.linkPinto.Text = "Julián Pinto";
            this.linkPinto.VisitedLinkColor = System.Drawing.Color.White;
            this.linkPinto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPinto_LinkClicked);
            // 
            // linkAugusto
            // 
            this.linkAugusto.ActiveLinkColor = System.Drawing.Color.White;
            this.linkAugusto.AutoSize = true;
            this.linkAugusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(170)))), ((int)(((byte)(244)))));
            this.linkAugusto.DisabledLinkColor = System.Drawing.Color.White;
            this.linkAugusto.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkAugusto.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkAugusto.LinkColor = System.Drawing.Color.White;
            this.linkAugusto.Location = new System.Drawing.Point(0, 62);
            this.linkAugusto.Name = "linkAugusto";
            this.linkAugusto.Size = new System.Drawing.Size(249, 42);
            this.linkAugusto.TabIndex = 4;
            this.linkAugusto.TabStop = true;
            this.linkAugusto.Text = "Augusto Texeira";
            this.linkAugusto.VisitedLinkColor = System.Drawing.Color.White;
            this.linkAugusto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAugusto_LinkClicked);
            // 
            // linkCristian
            // 
            this.linkCristian.ActiveLinkColor = System.Drawing.Color.White;
            this.linkCristian.AutoSize = true;
            this.linkCristian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(170)))), ((int)(((byte)(244)))));
            this.linkCristian.DisabledLinkColor = System.Drawing.Color.White;
            this.linkCristian.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkCristian.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkCristian.LinkColor = System.Drawing.Color.White;
            this.linkCristian.Location = new System.Drawing.Point(0, 162);
            this.linkCristian.Name = "linkCristian";
            this.linkCristian.Size = new System.Drawing.Size(283, 42);
            this.linkCristian.TabIndex = 3;
            this.linkCristian.TabStop = true;
            this.linkCristian.Text = "Cristian Rodríguez";
            this.linkCristian.VisitedLinkColor = System.Drawing.Color.White;
            this.linkCristian.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCristian_LinkClicked);
            // 
            // frmCreditos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(628, 252);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.epb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCreditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Créditos";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCreditos_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private enhancedPictureBox epb;
        private System.Windows.Forms.Timer tmr60;
        private System.Windows.Forms.Timer tmr15;
        private System.Windows.Forms.Timer tmr30;
        private LinkLabel linksAlan;
        private Panel panel1;
        private LinkLabel linkPinto;
        private LinkLabel linkAugusto;
        private LinkLabel linkCristian;
    }
}