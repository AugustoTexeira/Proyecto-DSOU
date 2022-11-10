using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProWork.De_Configuración__Cristian_
{
    public partial class frmUserStats : Form
    {
        public frmUserStats()
        {
            InitializeComponent();
            Program.tryToConnect();
            MySqlCommand cmd = new("select idusuario from usuario", Program.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();

            List<Point> buffer = new();
            int i = 1;
            while (rdr.Read())
            {
                buffer.Add(new(i, rdr.GetInt32(0)));
                i++;
            }
            rdr.Close();
            grf.Scale = new(i, grf.Scale.Height);
            grf.Points = buffer.ToArray();
        }
    }
}
