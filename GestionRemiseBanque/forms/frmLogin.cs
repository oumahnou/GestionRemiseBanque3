using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnValider_Click(object sender, EventArgs e)
        {
            TitreBancaire titre=new TitreBancaire("8888", new DateTime(2020, 2, 28), 100.00,10,20,30,true,true,1,15,new DateTime(2020,2,10),15, new DateTime(2020, 2, 28));
            
            TitreBancaireDao dao = new TitreBancaireDao("DESKTOP-JIHT5LS\\SQLEXPRESS", "GrbData", "Abdel", "0123");
            dao.ajouterTitreBancaire(titre);
        
        }
    }
}
