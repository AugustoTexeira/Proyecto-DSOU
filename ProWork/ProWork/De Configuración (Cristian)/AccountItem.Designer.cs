namespace ProWork
{
    partial class AccountItem
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfig.Location = new System.Drawing.Point(401, 52);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(6);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(164, 86);
            this.btnConfig.TabIndex = 0;
            this.btnConfig.Text = "⚙️";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Visible = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            this.btnConfig.MouseEnter += new System.EventHandler(this.btnConfig_MouseEnter);
            this.btnConfig.MouseLeave += new System.EventHandler(this.btnConfig_MouseLeave);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUser.Location = new System.Drawing.Point(142, 52);
            this.btnUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(164, 86);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "⛔";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Visible = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            this.btnUser.MouseEnter += new System.EventHandler(this.btnUser_MouseEnter);
            this.btnUser.MouseLeave += new System.EventHandler(this.btnUser_MouseLeave);
            // 
            // AccountItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnConfig);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AccountItem";
            this.Size = new System.Drawing.Size(725, 213);
            this.FontChanged += new System.EventHandler(this.AccountItem_FontChanged);
            this.SizeChanged += new System.EventHandler(this.AccountItem_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AccountItem_Paint);
            this.MouseEnter += new System.EventHandler(this.AccountItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.AccountItem_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
        public Button btnUser;
        public Button btnConfig;
    }
}
