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
            dataGridView1.DataSource = ds.Tables["TitresBancaires"];
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                Boolean isCheque = Convert.ToBoolean( row.Cells["isCheque"].Value);
                String remiseID = Convert.ToString(row.Cells["clmRemise"].Value);
                if (isCheque == true)
                {
                    row.Cells["clmType"].Value = "Cheque";
                }
                else
                {
                    row.Cells["clmType"].Value = "Effet";
                }
              
                if (remiseID=="")
                {
                    row.DefaultCellStyle.BackColor = Color.GreenYellow;
                    row.DefaultCellStyle.ForeColor = Color.OrangeRed;
                }

            }
            
        }
    }
}
