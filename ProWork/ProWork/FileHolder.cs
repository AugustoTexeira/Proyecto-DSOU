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

namespace ProWork
{
    public partial class FileHolder : UserControl
    {

        MySqlConnection conexion;

        public const short FileSize = 100;
        private List<Carpeta> carpetas = new List<Carpeta>();
        private List<Archivo> archivos = new List<Archivo>();
        public FileHolder()
        {
            InitializeComponent();
        }
        public void Conectar(MySqlConnection conexion) 
        { 
            this.conexion = conexion;
            MostrarCarpetas();
        }
        public void MostrarCarpetas()
        {
            if(!conexion.Ping())
            {
                conexion.Open();
            }
            MySqlCommand nombres = new("select idcarpeta, nombre from carpeta where carpetaPadre is NULL;", conexion);
            MySqlDataReader reader = nombres.ExecuteReader();
            while (reader.Read())
            {
                Carpeta carpeta = new Carpeta();
                carpeta.id = reader.GetInt32(0);
                carpeta.Nombre = reader.GetString(1);
                this.Add(carpeta);
            }
            conexion.Close();
        }
        private void FileHolder_Resize(object sender, EventArgs e)
        {
            ResetElementos();
            this.AutoScroll = false;
            this.HorizontalScroll.Visible = false;
            this.AutoScroll = true;
        }

        private void ResetElementos()
        {
            int n = 0;
            int fila = 0;
            int y = 0;
            for (int i = 0; i < carpetas.Count + archivos.Count; i++)
            {
                if ((10 + FileSize) * (i - n) + FileSize > this.ClientSize.Width)
                {
                    n = i;
                    fila++;
                    y = (10 + FileSize) * fila;
                }
                if (carpetas.Count > i)
                {
                    carpetas[i].Location = new Point((10 + FileSize) * (i - n), y);
                }
                else
                {
                    archivos[i - carpetas.Count].Location = new Point((10 + FileSize) * (i - n), y);
                }
            }
        }

        private void FileHolder_Load(object sender, EventArgs e)
        {
            
        }

        public void Add(Carpeta a)
        {
            carpetas.Add(a);
            a.CarpetaDoubleClick += Open;
            this.Controls.Add(a);
            ResetElementos();
        }

        public void Add(Archivo a)
        {
            archivos.Add(a);
            this.Controls.Add(a);
            ResetElementos();
        }

        public void Truncate()
        {
            this.Controls.Clear();
            carpetas.Clear();
            archivos.Clear();
        }

        private void Open(object sender, EventArgs e)
        {
            Truncate();
            if(!conexion.Ping())
            {
                conexion.Open();
            }
            MySqlCommand nombres = new("select idcarpeta, nombre from carpeta where IF(idcarpeta IN(select idcarpeta from carpeta where carpetaPadre = " + sender.ToString() + "),1,0);", conexion);
            MySqlDataReader reader = nombres.ExecuteReader();
            while (reader.Read())
            {
                Carpeta carpeta = new Carpeta();
                carpeta.id = reader.GetInt32(0);
                carpeta.Nombre = reader.GetString(1);
                this.Add(carpeta);
            }
            reader.Close();
            Entrar.Invoke(sender, e);
        }

        public event EventHandler Entrar;
    }
}
