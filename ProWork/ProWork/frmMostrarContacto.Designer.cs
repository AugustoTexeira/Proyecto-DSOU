namespace ProWork
{
    partial class frmMostrarContacto
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
            this.lblEmail = new System.Windows.Forms.LinkLabel();
            this.lblTel = new System.Windows.Forms.LinkLabel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.epb = new ProWork.enhancedPictureBox();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.ActiveLinkColor = System.Drawing.Color.White;
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.DisabledLinkColor = System.Drawing.Color.White;
            this.lblEmail.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblEmail.LinkColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(12, 276);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(507, 36);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.TabStop = true;
            this.lblEmail.Text = "ezponjares@gmail.com";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmail.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // lblTel
            // 
            this.lblTel.ActiveLinkColor = System.Drawing.Color.White;
            this.lblTel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTel.DisabledLinkColor = System.Drawing.Color.White;
            this.lblTel.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblTel.LinkColor = System.Drawing.Color.White;
            this.lblTel.Location = new System.Drawing.Point(12, 322);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(507, 36);
            this.lblTel.TabIndex = 13;
            this.lblTel.TabStop = true;
            this.lblTel.Text = "098479701";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTel.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoEllipsis = true;
            this.lblNombre.Font = new System.Drawing.Font("Raleway", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(12, 205);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(507, 54);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Juan Pérez";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtb
            // 
            this.rtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb.Font = new System.Drawing.Font("Raleway", 8.95F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb.ForeColor = System.Drawing.Color.White;
            this.rtb.Location = new System.Drawing.Point(83, 379);
            this.rtb.Name = "rtb";
            this.rtb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb.Size = new System.Drawing.Size(371, 266);
            this.rtb.TabIndex = 15;
            this.rtb.Text = "https://stackoverflow.com/questions/20328598/open-default-mail-client-along-with-" +
    "a-attachment";
            this.rtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtb_KeyPress);
            // 
            // epb
            // 
            this.epb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.epb.BackColor = System.Drawing.Color.Transparent;
            this.epb.BkgImage = global::ProWork.Properties.Resources.ContactoOscuro;
            this.epb.Circle = true;
            this.epb.Location = new System.Drawing.Point(190, 36);
            this.epb.Name = "epb";
            this.epb.Size = new System.Drawing.Size(150, 150);
            this.epb.TabIndex = 16;
            // 
            // frmMostrarContacto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(531, 657);
            this.Controls.Add(this.epb);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblEmail);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(549, 704);
            this.Name = "frmMostrarContacto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMostrarContacto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMostrarContacto_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private LinkLabel lblEmail;
        private LinkLabel lblTel;
        private Label lblNombre;
        private RichTextBox rtb;
        private enhancedPictureBox epb;
    }
}