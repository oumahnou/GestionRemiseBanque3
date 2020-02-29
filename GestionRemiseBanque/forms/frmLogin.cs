using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionRemiseBanque
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

       

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Param_Server == ""){

                ServerInstance si = new ServerInstance();
                si.getInstanceServer(cmbServer);
            }
            else
            {
                cmbServer.Items.Add(Properties.Settings.Default.Param_Server);
                cmbServer.SelectedIndex = 0;
                txtUser.Text = Properties.Settings.Default.Param_User_App;
                txtuserSql.Text = Properties.Settings.Default.Param_User_sql;
                txtPasswordSql.Text = Properties.Settings.Default.Param_Pass_sql;
                txtDatabase.Text = Properties.Settings.Default.Param_Database;

            }
            
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            TitreBancaire titre = new TitreBancaire("8888", new DateTime(2020, 2, 28), 100.00, 10, 20, 30, true, true, 1, 15, new DateTime(2020, 2, 10), 15, new DateTime(2020, 2, 28));

            TitreBancaireDao dao = new TitreBancaireDao(cmbServer.Text, txtDatabase.Text, txtuserSql.Text, txtPasswordSql.Text);
            dao.ajouterTitreBancaire(titre);

            if (cbSauvegarder.Checked == true)
            {
                Properties.Settings.Default.Param_Server = cmbServer.Text;
                Properties.Settings.Default.Param_Database = txtDatabase.Text;
                Properties.Settings.Default.Param_User_sql = txtuserSql.Text;
                Properties.Settings.Default.Param_Pass_sql = txtPasswordSql.Text;
                Properties.Settings.Default.Param_User_App = txtUser.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            ServerInstance si = new ServerInstance();
            String connectionString = "Server =" + cmbServer.Text + "; Database = " + txtDatabase.Text + "; User Id =" + txtuserSql.Text + "; Password = " + txtPasswordSql.Text + ";";

            if (si.IsServerConnected(connectionString))
            {
                MessageBox.Show("Connection reussie");
            }
            else
            {
                MessageBox.Show("Connection échoué");

            }
        }
    }
}
