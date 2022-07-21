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

        private DoubleBufferedPanel dplMain;
        private DoubleBufferedPanel dplMenuP;
        private System.Windows.Forms.Timer tmrMenu;
        private Label label1;
        private DoubleBufferedPanel dplMenuProyectos;
        private Label label2;
        private DoubleBufferedPanel dplMenuC;
        private Label label3;
        private DoubleBufferedPanel dplMenuConfig;
        private Label label4;
        private PictureBox pbxInicio;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}