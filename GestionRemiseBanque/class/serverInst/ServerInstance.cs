using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class ServerInstance
{
    public ServerInstance()
    {

    }

    public void getInstanceServer(ComboBox cmb)
    {
        SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
        System.Data.DataTable table = instance.GetDataSources();
        String Serv;
        foreach (DataRow row in table.Rows)
        {
            Serv = String.Concat(row["ServerName"], "\\", row["InstanceName"]);
            cmb.Items.Add(Serv);


        }
    }

    /// <summary>
    /// Test that the server is connected
    /// </summary>
    /// <param name="connectionString">The connection string</param>
    /// <returns>true if the connection is opened</returns>
    public bool IsServerConnected(string connectionString)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}

