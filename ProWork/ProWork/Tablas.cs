using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ProWork;
internal static class Tablas
{
    public static DataTable carga = new();
    public static DataTable contactos = new();
    public static System.ComponentModel.BackgroundWorker bgwResetTablas = new();

    public async  static void ResetTablas (object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        //try
        //{
        //    List < DataTable > list = new();

        //    MySqlCommand cmd = new("Select fecha, count(fecha) from carga group by fecha order by fecha", Program.connection);
        //    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
        //    list.Add(new());
        //    await adapter.FillAsync(list.Last());

        //    cmd = new();

        //    e.Result = list;
        //}
        //catch
        //{

        //}
    }

    public static void endWorker(object sender, System.ComponentModel.RunWorkerCompletedEventArgs r)
    {
        carga = ((List<DataTable>)r.Result)[0];

    }
}
