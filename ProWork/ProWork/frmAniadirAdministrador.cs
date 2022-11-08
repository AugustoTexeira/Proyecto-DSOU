﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProWork
{
    public partial class frmAniadirAdministrador : Form
    {
        private int id;
        public frmAniadirAdministrador(string usuario = "", int id = 0, bool ascender = false)
        {
            InitializeComponent();
            if(ascender)
            {
                Text = $"Ascender a {usuario} a administrador";
            }
            else
            {
                Text = $"Descender a {usuario}";
                cbtAscender.Texto = "DESCENDER ⬇";
            }
            this.id = id;
            ascendido += paqnosequeje;
        }

        private void paqnosequeje(object sender, EventArgs e)
        {

        }

        private void cbtAscender_Click(object sender, EventArgs e)
        {
            Program.tryToConnect();
            if (Text[..1] == "A")
            {
                //update usuario set administrador = true where idusuario=3 and exists (select administrador from (select * from usuario) as u where nombre='Pepe' and password=SHA2('Pep', 224))
                MySqlCommand cmd = new($"update usuario set administrador=true where idusuario={id} and exists (select administrador from (select * from usuario) as u where nombre='{Program.user}' and password=SHA2('{utbContra.txbText}', 224))", Program.connection);
                if(cmd.ExecuteNonQuery() == 1)
                {
                    ascendido.Invoke(true, e);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else
            {
                MySqlCommand cmd = new($"update usuario set administrador=false where idusuario={id} and exists (select administrador from (select * from usuario) as u where nombre='{Program.user}' and password=SHA2('{utbContra.txbText}', 224))", Program.connection);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    ascendido.Invoke(false, e);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
        }

        public event EventHandler ascendido;

        private void frmAniadirAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) { Application.Exit(); }
            this.Dispose();
        }
    }
}
