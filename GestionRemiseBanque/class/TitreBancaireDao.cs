using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Windows.Forms;

class TitreBancaireDao
{
    private SqlConnection cnn;
    private String connectionString;
    private SqlCommand command;
    private SqlDataAdapter adapter;
    private String sql;
    private SqlTransaction transaction;

    public TitreBancaireDao(String myServer,String myDataBase,String userName,String password)
    {
        connectionString = "Server ="+ myServer+"; Database = "+myDataBase+"; User Id ="+ userName+"; Password = "+password+";";
    }

    public int ajouterTitreBancaire(TitreBancaire titre)
    {
        try
        {
            sql = "INSERT INTO titresBancaires VALUES(@numero,@soicieteID,@echeance, @montant,@banqueID,@compteID,@isCheque,@isChequeHorsPlace,@remiseID,@createdBy,@dateCreation,@modifiedBy,@dateModification)";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            

            // Start a local transaction.
            transaction = cnn.BeginTransaction("InsertTransaction");
            command = new SqlCommand(sql, cnn);
            command.Transaction = transaction;
            adapter = new SqlDataAdapter();
            adapter.InsertCommand=command;
            command.Parameters.AddWithValue("@numero", titre.Numero);
            command.Parameters.AddWithValue("@soicieteID", titre.SocieteID);
            command.Parameters.AddWithValue("@echeance", titre.Echeance);
            command.Parameters.AddWithValue("@montant", titre.Montant);
            command.Parameters.AddWithValue("@banqueID", titre.BanqueID);
            command.Parameters.AddWithValue("@compteID", titre.CompteID);
            command.Parameters.AddWithValue("@isCheque", titre.IsCheque);
            command.Parameters.AddWithValue("@isChequeHorsPlace", titre.IsChequeHorsPlace);
            command.Parameters.AddWithValue("@remiseID", titre.RemiseID);
            command.Parameters.AddWithValue("@createdBy", titre.CreatedBy);
            command.Parameters.AddWithValue("@dateCreation", titre.DateCreation);
            command.Parameters.AddWithValue("@modifiedBy", titre.ModifiedBy);
            command.Parameters.AddWithValue("@dateModification1", titre.DateModification);

            adapter.InsertCommand.ExecuteNonQuery();
            transaction.Commit();
            command.Dispose();
        }
        catch(Exception e)
        {
            MessageBox.Show(e.Message);
            transaction.Rollback();
            cnn.Close();
            return 0;
        }

        cnn.Close();
        return 1;
    }

    public int modifierTitreBancaire(TitreBancaire titre)
    {
        try
        {
            sql = "UPDATE titresBancaires SET numero=@numero,societeID=@soicieteID,echeance=@echeance, montant=@montant,banqueID=@banqueID,compteID=@compteID,isCheque=@isCheque,isChequeHorsPlace=@isChequeHorsPlace,remiseID=@remiseID,createdBy=@createdBy,dateCreation=@dateCreation,modifiedBy=@modifiedBy,dateModification=@dateModification)";
            cnn = new SqlConnection(connectionString);
            cnn.Open();


            // Start a local transaction.
            transaction = cnn.BeginTransaction("UpdateTransaction");
            command = new SqlCommand(sql, cnn);
            command.Transaction = transaction;
            adapter = new SqlDataAdapter();
            adapter.InsertCommand = command;
            command.Parameters.AddWithValue("@numero", titre.Numero);
            command.Parameters.AddWithValue("@soicieteID", titre.SocieteID);
            command.Parameters.AddWithValue("@echeance", titre.Echeance);
            command.Parameters.AddWithValue("@montant", titre.Montant);
            command.Parameters.AddWithValue("@banqueID", titre.BanqueID);
            command.Parameters.AddWithValue("@compteID", titre.CompteID);
            command.Parameters.AddWithValue("@isCheque", titre.IsCheque);
            command.Parameters.AddWithValue("@isChequeHorsPlace", titre.IsChequeHorsPlace);
            command.Parameters.AddWithValue("@remiseID", titre.RemiseID);
            command.Parameters.AddWithValue("@createdBy", titre.CreatedBy);
            command.Parameters.AddWithValue("@dateCreation", titre.DateCreation);
            command.Parameters.AddWithValue("@modifiedBy", titre.ModifiedBy);
            command.Parameters.AddWithValue("@dateModification1", titre.DateModification);

            adapter.InsertCommand.ExecuteNonQuery();
            transaction.Commit();
            command.Dispose();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            transaction.Rollback();
            cnn.Close();
            return 0;
        }

        cnn.Close();
        return 1;

    }



}




