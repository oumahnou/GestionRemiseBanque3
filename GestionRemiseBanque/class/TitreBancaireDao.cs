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
            command.Parameters.AddWithValue("@dateModification", titre.DateModification);

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
            sql = "UPDATE titresBancaires SET societeID=@soicieteID,echeance=@echeance, montant=@montant,banqueID=@banqueID,"
                +"compteID=@compteID,isCheque=@isCheque,isChequeHorsPlace=@isChequeHorsPlace,remiseID=@remiseID,createdBy=@createdBy,"
                + "dateCreation=@dateCreation,modifiedBy=@modifiedBy,dateModification=@dateModification where numero=@numero";
            cnn = new SqlConnection(connectionString);
            cnn.Open();


            // Start a local transaction.
            transaction = cnn.BeginTransaction("UpdateTransaction");
            command = new SqlCommand(sql, cnn);
            command.Transaction = transaction;
            adapter = new SqlDataAdapter();
            adapter.UpdateCommand = command;
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

            adapter.UpdateCommand.ExecuteNonQuery();
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

    public int supprimerTitreBancaire(int idTitreBq)
    {

        try
        {
            sql = "DELETTE titresBancaires  where idTitreBq=@idTitreBq";
            cnn = new SqlConnection(connectionString);
            cnn.Open();


            // Start a local transaction.
            transaction = cnn.BeginTransaction("DeletteTransaction");
            command = new SqlCommand(sql, cnn);
            command.Transaction = transaction;
            adapter = new SqlDataAdapter();
            adapter.DeleteCommand = command;
            command.Parameters.AddWithValue("@idTitreBq", idTitreBq);
            

            adapter.DeleteCommand.ExecuteNonQuery();
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
    /*
     typeRech :
     0-tout
     1-Effets
     2-Cheques
     3-Cheques sur place
     4-cheques hors place
         
    */
    public DataSet listeTitresBancaires(int typeRech,DateTime Du,DateTime Au,String orderBy)
    {
        DataSet ds = new DataSet("TitresBancaires");
        try
        {
            sql = "SELECT idTitreBq,isCheque,numero,societeName,banqueName,montant,remiseID FROM titresBancaires,clients,banques WHERE echeance >= @du and echeance <=@au and clients.societeID = titresBancaires.societeID and banques.banqueID = titresBancaires.banqueID ";
            switch (typeRech)
            {
                case 0:
                    sql += "ORDER BY "+orderBy;
                    break;
                case 1:
                    sql += "isCheque = 0  ORDER BY " + orderBy;

                    break;

                case 2:
                    sql = "isCheque = 1  ORDER BY " + orderBy;

                    break;
                case 4:
                    sql = "isCheque = 1 and isChqHorsPlace=0  ORDER BY " + orderBy;

                    break;
                case 5:
                    sql = "isCheque = 1 and isChqHorsPlace=1  ORDER BY " + orderBy;
                    break;
                 
            }

            MessageBox.Show(sql);
            
            cnn = new SqlConnection(connectionString);
            cnn.Open();


        
            command = new SqlCommand(sql, cnn);
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            command.Parameters.AddWithValue("@du", Du);
            command.Parameters.AddWithValue("@au", Au);
            command.Parameters.AddWithValue("@orderBy", orderBy);
            //adapter.SelectCommand.ExecuteNonQuery();
            
            adapter.Fill(ds, "TitresBancaires");
            command.Dispose();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            cnn.Close();
           
        }

        cnn.Close();
        return ds;





    }
}




