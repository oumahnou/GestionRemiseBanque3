using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionRemiseBanque.forms.TitresBancaires
{
    public partial class frmListeTitresBancaires : Form
    {
        public frmListeTitresBancaires()
        {
            InitializeComponent();
        }

        private void frmListeTitresBancaires_Load(object sender, EventArgs e)
        {
            TitreBancaireDao dao = new TitreBancaireDao("DESKTOP-JIHT5LS\\SQLEXPRESS", "GrbData", "Abdel", "0123");
            DataSet ds =  dao.listeTitresBancaires(0, new DateTime(2020, 1, 1), new DateTime(2020, 2, 29), "idTitreBq");
           /* clmNumero.DataPropertyName = "numero";
            clmSociete.DataPropertyName = "societeID";
            clmBanque.DataPropertyName = "banqueID";
            clmMontant.DataPropertyName = "montant";
            clmRemise.DataPropertyName = "remiseID";*/
            dataGridView1.DataSource = ds.Tables["TitresBancaires"];
        }
    }
}
