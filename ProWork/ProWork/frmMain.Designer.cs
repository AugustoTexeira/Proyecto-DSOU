namespace ProWork
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menu = new ProWork.mainMenu();
            this.tmrDown = new System.Windows.Forms.Timer(this.components);
            this.tmrUp = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Black;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.SelectedScreen = ((byte)(0));
            this.menu.Size = new System.Drawing.Size(78, 673);
            this.menu.TabIndex = 0;
            // 
            // tmrDown
            // 
            this.tmrDown.Interval = 16;
            this.tmrDown.Tick += new System.EventHandler(this.tmrDown_Tick);
            // 
            // tmrUp
            // 
            this.tmrUp.Interval = 16;
            this.tmrUp.Tick += new System.EventHandler(this.tmrUp_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(480, 270);
            this.Name = "frmMain";
            this.Text = "ProWork";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPruebaa_FormClosed);
            this.ResizeEnd += new System.EventHandler(this.frmMain_ResizeEnd);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.frmPruebaa_Layout);
            this.ResumeLayout(false);

        }

        #endregion

        private mainMenu menu;
        private System.Windows.Forms.Timer tmrDown;
        private System.Windows.Forms.Timer tmrUp;
        private NotifyIcon notifyIcon1;
    }
}